using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using App.UI.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class booksModel : PageModel
    {
        private readonly BookManager manager;
        public List<BookVM> allBooks;
        public PagedList<BookVM> PagingAuthors { get; set; }

        public booksModel(BookManager manager)
        {
            this.manager = manager;
        }
        public void OnGet([FromQuery] int Page = 1)
        {
            allBooks = manager.GetAllBooks();
            PagingAuthors = PagedList<BookVM>.Create(allBooks.AsQueryable(), Page, 24);

        }
    }
}
