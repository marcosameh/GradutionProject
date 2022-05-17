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
        public void AddToCart(string userid,int BookID,string bookName,string photoPath,decimal bookPrice,string bookStore)
        {
            CartItem cartItem = new CartItem
            {
                userid=userid,
                ItemID=BookID,
                BookName = bookName,
                BookPhoto = photoPath,
                BookPrice = bookPrice,
                BookStore =bookStore
            };
            CartList.Add(cartItem);
        }
        public int CountListItems(string BookStore,string userid)
        {
            return CartList.Count(item=>item.BookStore.Equals(BookStore)&&item.userid.Equals(userid));
        }
        public void DeleteItem(int Id, string userid)
        {
            CartItem item=CartList.FirstOrDefault(item => item.ItemID==Id && item.userid.Equals(userid));
            CartList.Remove(item);
        }
        public decimal GetTotalPrice(string BookStore, string userid)
        {
            decimal totalPrice = 0;
            foreach (var item in CartList.Where(item => item.BookStore.Equals(BookStore) && item.userid.Equals(userid)))
            {
                totalPrice += item.BookPrice;
            }
            return totalPrice;
        }
        public void DeleteCartItemInSameBookStore(string BookStore, string userid)
        {

                CartList.RemoveAll(item=>item.BookStore.Equals(BookStore) && item.userid.Equals(userid));
            
        }
    }
}
