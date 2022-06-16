using App.Core.Manager;
using App.Core.Models;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace App.UI.Pages.Books
{
    [Authorize(Roles = "Librarian")]

    public class addModel : PageModel
    {
        private readonly BookManager bookManager;
        private readonly AuthorManager authorManager;
        private readonly BookCategoryManager bookCategoryManager;

        [BindProperty]
        public BookVM Book { get; set; }
        [BindProperty]
        public List<int> CategoryIds { get; set; }
        public List<BookCategoryVM> BookCategories { get; set; }
        public List<AuthorsVM> Authors { get; set; }
        public addModel(BookManager bookManager,AuthorManager authorManager , BookCategoryManager bookCategoryManager)
        {
            this.bookManager = bookManager;
            this.authorManager = authorManager;
            this.bookCategoryManager = bookCategoryManager;
        }
        public IActionResult OnGet()
        {
            BookCategories = bookCategoryManager.GetAllCategories();
            Authors = authorManager.GetAuthors();
            return Page();
        }
        public IActionResult OnPost()
        {
            //if (!ModelState.IsValid)
            //{
            //    return OnGet();
            //}
            if (Book.AudioFile != null)
            {
                Book.AduioUrl = FileManager.UploadFile(Book.AudioFile, "/wwwroot/audio/books/");
            }
            if (Book.PdfFile != null)
            {
                Book.AduioUrl = FileManager.UploadFile(Book.AudioFile, "/wwwroot/pdf/books/");
            }
            bookManager.AddBook(Book,CategoryIds);
            return Redirect("/Books/list");
        }
    }
}
