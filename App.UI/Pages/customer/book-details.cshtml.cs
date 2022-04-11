using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.CartManager;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using App.UI.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class book_detailsModel : PageModel
    {
        private readonly BookManager manger;
        public BookVM BookDetails;
        public List<BookVM >MostSellingBooks;
        public book_detailsModel(BookManager manger)
        {
            this.manger = manger;
        }
        public void OnGet(int Id)
        {
            BookDetails = manger.GetBookById(Id);
            MostSellingBooks = manger.GetMostSellingBook();
        }
       public void OnGetAddToCart(int Id)
        {
            BookDetails = manger.GetBookById(Id);
            Cart cart = Cart.GetInstance();
            cart.AddToCart(Id,
                BookDetails.Name,
                BookDetails.PhotoPath,
                BookDetails.BookPriceAfterDiscount,
                Global.UrlName
             );
        }
    }
}
