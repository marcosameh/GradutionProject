using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.ViewManger;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    //[Authorize(Roles = "Customer")]
    public class AuthorsModel : PageModel
    { 
        [BindProperty(SupportsGet =true)]
        public string SearchFor { get; set; }

        [BindProperty(SupportsGet =true)]
        public int PageIndex{ get; set; }
        private int NumCardsPerPage=16;
 
       

        private readonly AuthorManager athorManager;
        public Paging paging;
        public List<AuthorsVM> Authors;
        public AuthorsModel(AuthorManager athorManager)
        {
            this.athorManager = athorManager;
            paging = new Paging(NumCardsPerPage);
            PageIndex = 1;
        }
        public void OnGet()
        {
            paging.ItemNum = athorManager.GetAuthorsCount();
            Authors = athorManager.GetAuthors().Skip(paging.SkipNumBooks(PageIndex)).Take(NumCardsPerPage).ToList();
            
        }
    }
}
