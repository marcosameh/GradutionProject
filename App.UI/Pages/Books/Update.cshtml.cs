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
        private readonly BookCategoryManager bookCategoryManager;
        private readonly BookCategoryListManager bookCategoryListManager;

        [BindProperty(SupportsGet =true)]
        public BookVM Book { get; set; }

        [BindProperty(SupportsGet = true)]
        public List<AuthorsVM> Authors { get; set; }
        [BindProperty]
        public List<int> CategoryIds { get; set; }
        public IQueryable<BookCategoryList> SelectedCategory { get; set; }
        public List<BookCategoryVM> BookCategories { get; set; }

        public UpdateModel(BookManager bookManager ,AuthorManager authorManager,
            BookCategoryManager bookCategoryManager,BookCategoryListManager bookCategoryListManager)
        {
            this.bookManager = bookManager;
            this.authorManager = authorManager;
            this.bookCategoryManager = bookCategoryManager;
            this.bookCategoryListManager = bookCategoryListManager;
        }
        public void OnGet(int id )
        {
            Authors = authorManager.GetAuthors();
            Book = bookManager.GetBookById(id);
            BookCategories = bookCategoryManager.GetAllCategories();
            SelectedCategory = bookCategoryListManager.GetSlectedCategoriesIds(id);

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
        
            bookManager.UpdateBook(Book, CategoryIds);   
            return Redirect("/Books/list");



        }
    }
}
