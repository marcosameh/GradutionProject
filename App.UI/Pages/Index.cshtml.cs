using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.UI.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Manager;
using SharedTenant.Models;

namespace App.UI.Pages
{
    public class defaultModel : PageModel
    {
        private readonly CurrentTenantManager currentTenantManager;

        public IQueryable<BookStores> Bookstores { get; set; }
        [BindProperty(SupportsGet =true)]
        public string SearchValue { get; set; }
        public defaultModel(CurrentTenantManager  currentTenantManager)
        {
            this.currentTenantManager = currentTenantManager;
        }
        public void OnGet()
        {
            Bookstores = currentTenantManager.GetBookStores();
           // var userid = userManger.GetUserId(HttpContext.User);
            
        }
        public void OnPost(string SearchValue)
        {
            Bookstores = currentTenantManager.GetRelatedBookStores(SearchValue);

        }

    }
}
