using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.UI.Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Models;

namespace App.UI.Pages.customer
{
    [Authorize(Roles = "Customer")]
    public class uploaded_booksModel : PageModel
    {
        private readonly ExchangeBookManger bookManger;
        private readonly UserManager<ApplicationUser> userManger;
        public List<BooksForExchange> Books;
        public PagedList<BooksForExchange> PagingBooks { get; set; }
        [FromQuery(Name = "page")]
        public int PageNumber { get; set; } = 1;
        public uploaded_booksModel(ExchangeBookManger bookManger,
            UserManager<ApplicationUser> userManger)
        {
            this.bookManger = bookManger;
            this.userManger = userManger;
        }
        public void OnGet()
        {
            var userid = userManger.GetUserId(HttpContext.User);
            Books = bookManger.GetAllBooksByUser(userid);
            PagingBooks = PagedList<BooksForExchange>.Create(Books.AsQueryable(), PageNumber, 12);

        }
    }
}
