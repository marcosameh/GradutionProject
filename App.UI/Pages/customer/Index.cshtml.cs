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
    [Authorize(Roles = "Customer")]
    public class IndexModel : PageModel
    {
        private readonly KitabiContext context;
        private readonly UserManager<ApplicationUser> userManager;
        public OffersView Offers;

        public LibrarianView Librarian;
        [BindProperty(SupportsGet =true)]
        public string SearchResult{ get; set; }
        public IndexModel(KitabiContext context, UserManager<ApplicationUser> userManager)
        {
            Offers = new OffersView(context);
            this.context = context;
            this.userManager = userManager;
            Librarian = new LibrarianView(userManager);
        }


        public void OnGet()
        {
           
        }
    }
}
