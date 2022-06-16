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

    public class AddModel : PageModel
    {
        private readonly BookCategoryManager categoryManager;
        [BindProperty]
        public BookCategoryVM Categories { get; set; }

        public AddModel(BookCategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return OnGet();
            }
            categoryManager.AddCategory(Categories);
            return Redirect("/BookCategory/List");
        }
    }
}
