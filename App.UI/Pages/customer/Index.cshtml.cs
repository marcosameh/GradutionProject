using App.Core.Models;
using App.Customer.Managers;
using App.Customer.Views;
using App.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using System.Collections.Generic;

namespace App.UI.Pages.Customer
{
    //[Authorize(Roles = "Customer")]
    public class IndexModel : PageModel
    {
        private readonly BookMangers bookManger;
        public List<Book> FeatureBooks;
        public List<Book> NewArrivals;

        public IndexModel(BookMangers bookManger)
        {
            this.bookManger = bookManger;
        }


        public void OnGet()
        {
            FeatureBooks = bookManger.GetfeaturedBooks(10);
            NewArrivals = bookManger.GetNewArrivalls(16);

        }

    }
}
