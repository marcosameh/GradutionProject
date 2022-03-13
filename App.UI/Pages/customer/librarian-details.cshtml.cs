using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.ViewManger;
using App.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;

namespace App.UI.Pages.customer
{
    public class librarian_detailsModel : PageModel
    {
        private readonly LibrarianView librarian;

        public librarian_detailsModel(LibrarianView Librarian)
        {
            librarian = Librarian;
        }

        public ApplicationUser Lib{ get; set; }
        [BindProperty(SupportsGet = true)]
        public string LibrarianID { get; set; }
        public async Task OnGetAsync()
        {
            Lib = await librarian.GetLibrarianById(LibrarianID);
        }
    }
}
