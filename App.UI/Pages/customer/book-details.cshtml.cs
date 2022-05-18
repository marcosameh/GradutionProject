using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.CartManager;
using App.Customer.RecommendedSystem;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using App.UI.Configurations;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Models;

namespace App.UI.Pages.customer
{
    public class book_detailsModel : PageModel
    {
        private readonly BookManager bookManger;
        private readonly RecommenedBooksManger recommenedBooksManger;
        private readonly UserManager<ApplicationUser> userManger;
        public BookVM BookDetails;
        public List<BookVM >MostSellingBooks;
        public List<CustomerRecomendedBook> recomendedBooks;
        public book_detailsModel(BookManager bookManger ,
            RecommenedBooksManger recommenedBooksManger,
            UserManager<ApplicationUser> userManger)
        {
            this.bookManger = bookManger;
            this.recommenedBooksManger = recommenedBooksManger;
            this.userManger = userManger;
        }
        public void OnGet(int Id)
        {
            BookDetails = bookManger.GetBookById(Id);
            MostSellingBooks = bookManger.GetMostSellingBook();
            var userid = userManger.GetUserId(HttpContext.User);
            if(!string.IsNullOrEmpty( userid))
                recomendedBooks = recommenedBooksManger.GetRecommenedBooks(userid);


        }
       

    }
}
