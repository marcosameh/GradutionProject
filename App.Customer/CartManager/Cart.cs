using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.CartManager
{
    public class Cart
    {
        private static Cart Instance ;
        public  List<CartItem> CartList;
        public static Cart GetInstance()
        {
            if (Instance == null)
            {
                Instance = new Cart();
                
            }
                return Instance;
        }
        private Cart()
        {
            CartList = new List<CartItem>();
        }
        public void AddToCart(int ID,string bookName,string photoPath,decimal bookPrice,string bookStore)
        {
            CartItem cartItem = new CartItem
            {
                ItemID=ID,
                BookName = bookName,
                BookPhoto = photoPath,
                BookPrice = bookPrice,
                BookStore =bookStore
            };
            CartList.Add(cartItem);
        }
        public int CountListItems()
        {
            return CartList.Count();
        }
        public void DeleteItem(int Id)
        {
            CartItem item=CartList.FirstOrDefault(item => item.ItemID==Id);
            CartList.Remove(item);
        }
        public decimal GetTotalPrice()
        {
            decimal totalPrice = 0;
            foreach (var item in CartList)
            {
                totalPrice += item.BookPrice;
            }
            return totalPrice;
        }
        public void DeleteCartItemInSameBookStore(string BookStore)
        {

                CartList.RemoveAll(item=>item.BookStore.Equals(BookStore));
            
        }
    }
}
