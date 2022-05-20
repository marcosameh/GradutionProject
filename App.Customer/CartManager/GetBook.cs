using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.CartManager
{
    public class GetBook
    {
        BaseRepo<Book> BookRepo;
        public GetBook(KitabiContext context)
        {
            BookRepo = new BaseRepo<Book>(context);
        }
        private void IncreamentBookSells(int BookID)
        {
            Book book = BookRepo.GetOne(book=>book.Id==BookID);
            book.NumSells++;
            BookRepo.Edit(book);
        }
       
        public void IncreamentAllBookSellsInTheCart(string BookStore,string userid)
        {
            Cart cart = Cart.GetInstance();
            foreach (var item in cart.CartList.Where(book=>book.BookStore.Equals(BookStore)))
            {
                IncreamentBookSells(item.ItemID);

            }
            //cart.DeleteCartItemInSameBookStore(BookStore,userid);
        }

    }
}
