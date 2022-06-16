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
    public class UpdateModel : PageModel
    {
        private readonly BookCategoryManager categoryManager;
        [BindProperty(SupportsGet =true)]
        public BookCategoryVM Categories { get; set; }

        public UpdateModel(BookCategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }

        public void OnGet(int id)
        {
            Categories = categoryManager.GetCategoryById(id); 
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            categoryManager.UpdateCategory(Categories);
            return Redirect("/BookCategory/List");
        }
    }
}
