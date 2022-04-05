using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.BookCategory
{
    [Authorize(Roles = "Librarian")]
    public class DeleteModel : PageModel
    {
        private readonly BookCategoryManager categoryManager;
        [BindProperty]
        public BookCategoryVM Categories { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public DeleteModel(BookCategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }
        public void OnGet()
        {
            Categories = categoryManager.GetCategoryById(Id);
        }
        public IActionResult OnPost()
        {
            categoryManager.DeleteCategory(Id);
            return Redirect("/BookCategory/List");
        }
    }
}
