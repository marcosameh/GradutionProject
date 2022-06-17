using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Manager;
using SharedTenant.Models;

namespace App.UI.Pages.Bookstores
{
    [Authorize(Roles="Admin")]
    public class AddModel : PageModel
    {
        private readonly CurrentTenantManager BookStoreManager;

        [BindProperty]
        public BookStores BookStore { get; set; }
        public AddModel(CurrentTenantManager currentTenantManager )
        {
           
            this.BookStoreManager = currentTenantManager;
        }

        public void OnGet()
        {
        }
        public void OnPost()
        {
            BookStoreManager.AddBookStore(BookStore);
        }
    }
}
