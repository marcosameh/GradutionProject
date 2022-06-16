using App.Core.Models;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace App.UI.Pages.Books
{
    
    [Authorize(Roles = "Librarian")]

    public class DeleteModel : PageModel
    {
        private readonly BookManager bookManager;
        [BindProperty]
        public BookVM Book { get; set; }
        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }

        public DeleteModel(BookManager bookManager)
        {
            this.bookManager = bookManager;
        }
            public void OnGet()
        {

            Book = bookManager.GetBookById(Id);


        }
        public IActionResult OnPost()
        {
            bookManager.DeleteBook(Id);
            return Redirect("/Books/list");
        }
    }
}
