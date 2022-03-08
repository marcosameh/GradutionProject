using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using App.Librarian.Managers;
using App.Librarian.ViewModels;

using System.Collections.Generic;
using App.Core.Models;

namespace App.UI.Pages.Books
{
    [Authorize(Roles = "Librarian")]
    public class ListModel : PageModel
    {

        private readonly BookManager bookManager;
        public List<BookVM> Book;



        public ListModel(BookManager bookManager)
        {
            this.bookManager = bookManager;
        }
        public void OnGet()
        {
            Book = bookManager.GetAllBooks();
            
        }
        public IActionResult OnGetDisplayBooks()
        {
            Book = bookManager.GetAllBooks();
            return new JsonResult(Book);
        }
    }
}
