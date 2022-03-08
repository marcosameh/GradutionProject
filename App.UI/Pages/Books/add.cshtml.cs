using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.Books
{
    [Authorize(Roles = "Librarian")]

    public class addModel : PageModel
    {
        private readonly BookManager bookManager;

        [BindProperty]
        public BookVM Book { get; set; }
        public addModel(BookManager bookManager)
        {
            this.bookManager = bookManager;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return OnGet();
            }

            bookManager.AddBook(Book);
            return Redirect("/Books/list");
        }
    }
}
