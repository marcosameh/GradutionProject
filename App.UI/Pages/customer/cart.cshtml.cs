using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.CartManager;
using App.UI.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class cartModel : PageModel
    {
        private readonly GetBook getBook;
        public Cart cart;
        public cartModel(GetBook getBook )
        {
            cart = Cart.GetInstance();
            this.getBook = getBook;
        }
        public void OnGet(int Id=0)
        {
            if(Id!=0)
            {
                cart.DeleteItem(Id);
            }
        }
        public void OnPost()
        {
            getBook.IncreamentAllBookSellsInTheCart(Global.UrlName);
        }
    }
}
