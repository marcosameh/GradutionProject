using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Domain;
using App.Core.Models;
using App.Customer.ViewManger;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class CustomerWelcomePageModel : PageModel
    {
        private readonly KitabiContext context;
        private readonly UserManager<ApplicationUser> userManager;
        public Offers Offers;

        public LibrarianView Librarian;
        public CustomerWelcomePageModel(KitabiContext context, UserManager<ApplicationUser> userManager)
        {
            Offers = new Offers(context);
            this.context = context;
            this.userManager = userManager;
            Librarian = new LibrarianView(userManager);
        }


        public void OnGet()
        {

        }
    }
}

