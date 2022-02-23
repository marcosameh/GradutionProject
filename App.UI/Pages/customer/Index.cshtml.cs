using System.Linq;
using System.Threading.Tasks;
using App.Core.Domain;
using App.Core.Models;
using App.Customer.ViewManger;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.Customer
{
    //[Authorize(Roles = "Customer")]
    public class IndexModel : PageModel
    {

        private readonly UserManager<ApplicationUser> userManager;
       
 


        [BindProperty(SupportsGet =true)]
        public string SearchFor { get; set; }
        public LibrarianView Librarian { get; }
        public OffersView Offers { get; }

        public IndexModel( LibrarianView librarian,OffersView offers)
        {
            Librarian = librarian;
            Offers = offers;

        }


        public void OnGet()
        {
           
        }
      
    }
}
