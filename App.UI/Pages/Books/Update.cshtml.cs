using App.Core.Manager;
using App.Core.Models;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using System.Linq;

namespace App.UI.Pages.Books
{
    public class UpdateModel : PageModel
    {
        private readonly BookManager bookManager;
        private readonly AuthorManager authorManager;

        [BindProperty(SupportsGet =true)]
        public BookVM Book { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<AuthorsVM> Authors { get; set; }

        public UpdateModel(BookManager bookManager ,AuthorManager authorManager )
        {
            this.bookManager = bookManager;
            this.authorManager = authorManager;
        }
        public void OnGet(int id )
        {
            Authors = authorManager.GetAuthors();
            Book= bookManager.GetBookById(id);
        }
        public IActionResult OnPost()
        {
            if (Book.PhotoFile != null)
            {
                Book.Photo = FileManager.UploadPhoto(Book.PhotoFile, "/wwwroot/photos/Books/", 150, 150);

            }
            if (Book.AudioFile != null)
            {
                Book.AduioUrl = FileManager.UploadFile(Book.AudioFile, "/wwwroot/audio/books/");
            }
            if (Book.PdfFile != null)
            {
                Book.AduioUrl = FileManager.UploadFile(Book.AudioFile, "/wwwroot/pdf/books/");
            }
            bookManager.UpdateBook(Book);
            return Redirect("/Books/list");

            
        }
    }
}
