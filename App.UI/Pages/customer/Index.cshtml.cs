using App.Customer.ViewManger;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;

namespace App.UI.Pages.Customer
{
    //[Authorize(Roles = "Customer")]
    public class IndexModel : PageModel
    {
        [BindProperty(SupportsGet = true)]
        public string SearchFor { get; set; }


        public LibrarianView Librarian { get; }
        public OffersView Offers { get; }

        public IndexModel(LibrarianView librarian, OffersView offers)
        {
            Librarian = librarian;
            Offers = offers;

        }


        public void OnGet()
        {

        }

    }
}
