using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.Librarian.Managers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Models;

namespace App.UI.Pages.Books
{
    public class WaitingBooksModel : PageModel
    {
        private readonly ExchangeBookManger bookManager;

        public IQueryable<BooksForExchange> WaitingBooks { get; set; } 
        public WaitingBooksModel(ExchangeBookManger bookManager)
        {
            this.bookManager = bookManager;
        }
        public void OnGet()
        {
            WaitingBooks=bookManager.GetWaitingBooks();
        }
    }
}
