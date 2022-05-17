using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.CartManager
{
    public class CartItem
    {
        public string userid { get; set; }
        public int ItemID { get; set; }
        public string BookPhoto { get; set; }
        public string BookName { get; set; }
        public decimal BookPrice { get; set; }
        public string BookStore{ get; set; }
    }
}
