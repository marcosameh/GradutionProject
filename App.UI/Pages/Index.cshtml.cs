using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.UI.Configurations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Manager;
using SharedTenant.Models;

namespace App.UI.Pages
{
    public class defaultModel : PageModel
    {
        private readonly CurrentTenantManager currentTenantManager;

        public IQueryable<BookStores> Bookstores { get; set; }
        public defaultModel(CurrentTenantManager  currentTenantManager)
        {
            this.currentTenantManager = currentTenantManager;
        }
        public void OnGet()
        {
            Bookstores = currentTenantManager.GetBookStores();
        }
        public void OnGetSetUrl(string UrlName)
        {
            Global.UrlName = UrlName;
            //Bookstores = currentTenantManager.GetBookStores();
        }
    }
}
