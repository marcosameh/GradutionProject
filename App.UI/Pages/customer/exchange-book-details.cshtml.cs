using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.Customer.ViewModel;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Models;

namespace App.UI.Pages.customer
{
    public class exchange_book_detailsModel : PageModel
    {
        private readonly ExchangeBookManger bookManger;
        private readonly RecommenedBooksManger recommenedBooksManger;
        private readonly UserManager<ApplicationUser> userManger;
        public BookForExchangeVM BookDetails;
        public List<CustomerRecomendedBook> recomendedBooks;

        public exchange_book_detailsModel(ExchangeBookManger bookManger,
            RecommenedBooksManger recommenedBooksManger,
            UserManager<ApplicationUser> userManger)
        {
            this.bookManger = bookManger;
            this.recommenedBooksManger = recommenedBooksManger;
            this.userManger = userManger;
        }
        public void OnGet(int id)
        {
            BookDetails = bookManger.GetBookByID(id);
            var userid = userManger.GetUserId(HttpContext.User);
            recomendedBooks = recommenedBooksManger.GetRecommenedBooks(userid);
        }
    }
}
