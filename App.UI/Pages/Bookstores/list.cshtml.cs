using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Manager;
using SharedTenant.Models;
using System.Linq;

namespace App.UI.Pages.Bookstores
{
    [Authorize(Roles="Admin")]
    public class IistModel : PageModel
    {
        private readonly CurrentTenantManager currentTenantManager;

        public IQueryable<BookStores> BookStores { get; set; }
        public IistModel(CurrentTenantManager currentTenantManager)
        {
            this.currentTenantManager = currentTenantManager;
        }
        public IActionResult OnGetDisplayBookStores()
        {
            BookStores = currentTenantManager.GetBookStores();
            return new JsonResult(BookStores);
        }
        

    }
}
