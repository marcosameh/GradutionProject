using App.Customer.CartManager;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using App.UI.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using System;
using System.Collections.Generic;

namespace App.UI.Pages.Customer
{
    //[Authorize(Roles = "Customer")]
    public class IndexModel : PageModel
    {
        private readonly BookManager bookManger;
        public List<BookVM> FeatureBooks;
        public List<BookVM> NewArrivals;
        public BookVM BookDetails;

        public IndexModel(BookManager bookManger

            )

        {
            this.bookManger = bookManger;
        }


        public void OnGet()
        {
            FeatureBooks = bookManger.GetfeaturedBooks();
            NewArrivals = bookManger.GetNewArrivalls();

        }
        public void OnPost(string SearchValue)
        {

        }


    }
}
