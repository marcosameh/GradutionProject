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

        [BindProperty]
        public BookVM Book { get; set; }

        public List<AuthorsVM> Authors { get; set; }
        public addModel(BookManager bookManager,AuthorManager authorManager)
        {
            this.bookManager = bookManager;
            this.authorManager = authorManager;
        }
        public IActionResult OnGet()
        {

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
            bookManager.AddBook(Book);
            return Redirect("/Books/list");
        }
    }
}
