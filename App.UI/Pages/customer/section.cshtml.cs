using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.Views;
using App.UI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class sectionModel : PageModel
    {
        public List<NumBooksInCategory> CategoryDetails;
        public readonly SectionView sectionView;
        public sectionModel(SectionView sectionView)
        {
            this.sectionView = sectionView;
        }
        public void OnGet()
        {
            CategoryDetails = sectionView.GetCategoriesDetails();
        }
    }
}
