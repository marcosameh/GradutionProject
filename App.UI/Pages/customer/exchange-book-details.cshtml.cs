using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.Customer.ViewModel;
using App.Customer.WishlistManger;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Models;

namespace App.UI.Pages.customer
{
    [Authorize(Roles = "Customer")]
    public class exchange_book_detailsModel : PageModel
    {
        private readonly ExchangeBookManger bookManger;
        private readonly RecommenedBooksManger recommenedBooksManger;
        private readonly UserManager<ApplicationUser> userManger;
        public BookForExchangeVM BookDetails;
        public List<CustomerRecomendedBook> recomendedBooks;
        public WishlistCRUD WishlistCRUD { get; }
        public int wishid;
        public exchange_book_detailsModel(ExchangeBookManger bookManger,
            RecommenedBooksManger recommenedBooksManger,
            UserManager<ApplicationUser> userManger,
            WishlistCRUD wishlistCRUD)
        {
            this.bookManger = bookManger;
            this.recommenedBooksManger = recommenedBooksManger;
            this.userManger = userManger;
            WishlistCRUD = wishlistCRUD;
        }



        public async Task OnGet(int id)
        {
            BookDetails = bookManger.GetBookByID(id);
            var userid = userManger.GetUserId(HttpContext.User);
            if (!string.IsNullOrEmpty(userid))
            {
                recomendedBooks = recommenedBooksManger.GetRecommenedBooks(userid);
                var user = await userManger.FindByIdAsync(BookDetails.OwnerId);
                string BookStoree = await userManger.GetUserNameAsync(user);


                wishid = WishlistCRUD.FindWish(userid, BookStoree, id);
            }
        }
        public async Task OnGetAddToWishlist(int Id)
        {
            var userid = userManger.GetUserId(HttpContext.User);

            if (!string.IsNullOrEmpty(userid))
            {
                BookDetails = bookManger.GetBookByID(Id);
                var user = await userManger.FindByIdAsync(BookDetails.OwnerId);
                WishlistCRUD.AddToWishlist(new WishlistVM
                {
                    BookId = Id,
                    BookName = BookDetails.Name,
                    BookPhoto = BookDetails.PhotoPath,
                    CustomerId = userid,
                    BookStore = await userManger.GetUserNameAsync(user),
                    ForExchange=true
                });
            }



        }
    }
}
