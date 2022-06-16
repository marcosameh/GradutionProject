using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.UI.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Models;

namespace App.UI.Pages.customer
{
    public class books_for_exchangeModel : PageModel
    {
        public List<BooksForExchange> BooksForExchange;
        private readonly ExchangeBookManger exchangeBookManger;

        public PagedList<BooksForExchange> PagingBooks { get; set; }
        [FromQuery(Name = "page")]
        public int PageNumber { get; set; } = 1;
        public books_for_exchangeModel(ExchangeBookManger exchangeBookManger)
        {
            this.exchangeBookManger = exchangeBookManger;
        }
        public void OnGet()
        {
            BooksForExchange = exchangeBookManger.GetAllExchangeBook();
            PagingBooks = PagedList<BooksForExchange>.Create(BooksForExchange.AsQueryable(), PageNumber, 12);

        }
    }
}
