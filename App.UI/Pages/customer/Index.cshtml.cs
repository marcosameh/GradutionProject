using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace App.UI.Pages.Customer
{
    //[Authorize(Roles = "Customer")]
    public class IndexModel : PageModel
    {
        private readonly BookManager bookManger;
        public List<BookVM> FeatureBooks;
        public List<BookVM> NewArrivals;

        public IndexModel(BookManager bookManger)
        {
            this.bookManger = bookManger;
        }


        public void OnGet()
        {
            FeatureBooks = bookManger.GetfeaturedBooks();
            NewArrivals = bookManger.GetNewArrivalls();

        }
       

    }
}
