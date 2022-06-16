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
        public PagedList<BookVM> PagingBooks { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchValue { get; set; }
        [FromQuery(Name = "page")]
        public int PageNumber { get; set; } = 1;
        public booksModel(BookManager manager)
        {
            this.manager = manager;
        }
        public void OnGet()
        {
            allBooks = manager.GetAllBooks();
            PagingBooks = PagedList<BookVM>.Create(allBooks.AsQueryable(), PageNumber, 2);

        }
        public void OnPost()
        {
            allBooks = manager.GetMatchedBooks(SearchValue);
            PagingBooks = PagedList<BookVM>.Create(allBooks.AsQueryable(), PageNumber, 2);
        }
    }
}
