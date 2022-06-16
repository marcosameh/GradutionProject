using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Manager;
using App.Customer.RecommendedSystem;
using App.Customer.ViewModel;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Models;

namespace App.UI.Pages.customer
{
    [Authorize(Roles = "Customer")]
    public class uploadbookModel : PageModel
    {
        private readonly ExchangeBookManger bookManger;
        [BindProperty]
        public List<int> CategoryIds { get; set; }
        public List<ExchangBookCategory> allCategories { get; set; }
        [BindProperty(SupportsGet =true)]
        public BookForExchangeVM BookVM { get; set; }

        public uploadbookModel(ExchangeBookManger bookManger)
        {
            this.bookManger = bookManger;
        }
        public void OnGet()
        {
            allCategories = bookManger.GetAllCategories();
        }
        public IActionResult OnPost()
        {
            if(CategoryIds.Count==0)
            {
                allCategories = bookManger.GetAllCategories();
                ModelState.AddModelError("","At least select a category from the category list");
                return Page();
            }
            if (BookVM.AudioFile != null)
            {
                BookVM.AduioUrl = FileManager.UploadFile(BookVM.AudioFile, "/wwwroot/audio/books/");
            }
            if (BookVM.PdfFile != null)
            {
                BookVM.AduioUrl = FileManager.UploadFile(BookVM.AudioFile, "/wwwroot/pdf/books/");
            }
            BookVM.IsActive = false;
            bookManger.UploadBook(BookVM, CategoryIds);
            return Redirect("/my/uploaded-books");
        }
    }
}
