using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Models;
using App.Customer.CartManager;
using App.Customer.RecommendedSystem;
using App.Customer.WishlistManger;
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
   // [Authorize(Roles = "Customer")]
    public class book_detailsModel : PageModel
    {
        private readonly BookManager bookManger;
       public RecommenedBooksManger recommenedBooksManger { get; set; }
        private readonly UserManager<ApplicationUser> userManger;
        private readonly BookCategoryListManager categoryListManager;
        public WishlistCRUD wishlistCRUD;
        public int wishid;
        public BookVM BookDetails;
        public List<BookVM> MostSellingBooks;
        public List<CustomerRecomendedBook> recomendedBooks;
        public List<string> bookCategories;
        public List<BookCategoryList> BooksBasedOnCategory;
        public book_detailsModel(BookManager bookManger,
            RecommenedBooksManger recommenedBooksManger,
            UserManager<ApplicationUser> userManger,
            BookCategoryListManager categoryListManager,
            WishlistCRUD wishlistCRUD)
        {
            this.bookManger = bookManger;
            this.recommenedBooksManger = recommenedBooksManger;
            this.userManger = userManger;
            this.categoryListManager = categoryListManager;
            this.wishlistCRUD = wishlistCRUD;
        }
        public void OnGet(int Id)
        {
            BookDetails = bookManger.GetBookById(Id);
            bookCategories = categoryListManager.GetBookCategories(Id);
            MostSellingBooks = bookManger.GetMostSellingBook();
            BooksBasedOnCategory = bookManger.GetAllBookFromSameCategory(Id);
            var userid = userManger.GetUserId(HttpContext.User);
            if (!string.IsNullOrEmpty(userid))
            {  recomendedBooks = recommenedBooksManger.GetRecommenedBooks(userid,10);
               wishid = wishlistCRUD.FindWish(userid, Global.UrlName,Id);
            }


        }
        public void OnGetAddToCart(int Id)
        {
            var userid = userManger.GetUserId(HttpContext.User);

            if (!string.IsNullOrEmpty(userid))
            {
                BookDetails = bookManger.GetBookById(Id);
                Cart cart = Cart.GetInstance();
                cart.AddToCart(
                    userid,
                    Id,
                    BookDetails.Name,
                    BookDetails.PhotoPath,
                    Convert.ToDecimal(BookDetails.BookPriceAfterDiscount),
                    Global.UrlName
                 );
            }



        } 
        
        public void OnGetAddToWishlist(int Id)
        {
            var userid = userManger.GetUserId(HttpContext.User);

            if (!string.IsNullOrEmpty(userid))
            {
                BookDetails = bookManger.GetBookById(Id);
                wishlistCRUD.AddToWishlist(new WishlistVM
                {
                    BookId = Id,
                    BookName = BookDetails.Name,
                    BookPhoto = BookDetails.PhotoPath,
                    CustomerId = userid,
                    BookStore = Global.UrlName,
                    ForExchange=false
                    
                }) ;
            }



        } 
       
    }
}
