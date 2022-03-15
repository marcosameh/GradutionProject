using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.Views
{
    public class Paging
    {
        public int ItemNum{ get; set; }

     
     
        public int ItemPerPage { get; }

        public Paging( int ItemPerPage)
        {
           
            this.ItemPerPage = ItemPerPage;
        }
        public int GetNumOfPages()
        {
            if(ItemNum % ItemPerPage==0)
            {
                return (ItemNum / ItemPerPage);
            }
            return (ItemNum / ItemPerPage) + 1;
        }
        public int SkipNumBooks(int CurrentPage)
        {
            return (CurrentPage - 1) * ItemPerPage;
        }
    }
}
