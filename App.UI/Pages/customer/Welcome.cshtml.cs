using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Models;
using App.Customer.ViewManger;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class CustomerWelcomePageModel : PageModel
    {
        private readonly KitabiContext context;
        public Offers Offers;
        public CustomerWelcomePageModel(KitabiContext context)
        {
            Offers = new Offers(context);
            this.context = context;
        }
        public void OnGet()
        {
        }
    }
}
