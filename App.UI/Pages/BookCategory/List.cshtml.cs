using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using App.Librarian.ViewModels;
using App.Librarian.Managers;

namespace App.UI.Pages.BookCategory
{
    [Authorize(Roles = "Librarian")]

    public class ListModel : PageModel
    {
        private readonly BookCategoryManager categoryManager;

        public List<BookCategoryVM> Categories;
        public ListModel(BookCategoryManager categoryManager)
        {
            this.categoryManager = categoryManager;
        }
        public void OnGet()
        {
            Categories = categoryManager.GetAllCategories();
        }
        public IActionResult OnGetDisplayCategories()
        {
            Categories = categoryManager.GetAllCategories();
            return new JsonResult(Categories);
        }
    }
}
