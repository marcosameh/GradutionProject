using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.WishlistManger
{
    public class WishlistVM
    {
        public int WishId { get; set; }
        public string CustomerId { get; set; }
        public int BookId { get; set; }
        public string BookStore { get; set; }
        public string BookPhoto { get; set; }
        public string BookName { get; set; }
        public bool ForExchange { get; set; }
        public string OwnerName
        {
            get
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(BookStore).ToString();
                    return addr.Substring(0, addr.IndexOf("@"));
                }
                catch
                {
                    return BookStore;
                }

            }
        }
    }
}
