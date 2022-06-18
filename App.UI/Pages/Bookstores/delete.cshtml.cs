using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Manager;
using SharedTenant.Models;
using System.Threading.Tasks;

namespace App.UI.Pages.Bookstores
{
    [Authorize(Roles="Admin")]
    public class deleteModel : PageModel
    {
        private readonly CurrentTenantManager bookStoreManager;
        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty(SupportsGet = true)]
        public int Id { get; set; }
        [BindProperty]
        public string UserId { get; set; }
        public BookStores BookStore { get; set; }

        public deleteModel(CurrentTenantManager BookStoreManager, UserManager<ApplicationUser> UserManager)
        {
            bookStoreManager = BookStoreManager;
            userManager = UserManager;
        }
        public void OnGet()
        {
            BookStore = bookStoreManager.GetBookStore(Id);
          
        }
        public IActionResult OnPost()
        {
          
            bookStoreManager.DeleteBookstore(Id);

            return Redirect("/Bookstores/list");
        }
    }
}
