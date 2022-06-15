using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.Views;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using App.UI.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Manager;

namespace App.UI.Pages.customer
{
    //[Authorize(Roles = "Customer")]
    public class AuthorsModel : PageModel
    { 
      

       

        private readonly AuthorManager athorManager;
        public List<AuthorsVM> Authors;
        public PagedList<AuthorsVM> PagingAuthors { get; set; }

        [FromQuery(Name = "page")]
        public int PageNumber { get; set; } = 1;
        public AuthorsModel(AuthorManager athorManager)
        {
            this.athorManager = athorManager;
          
        }


        public void OnGet()
        {

           
            Authors = athorManager.GetAuthors();
            PagingAuthors = PagedList<AuthorsVM>.Create(Authors.AsQueryable(), PageNumber, 12);


        }
        public void OnPost(string SearchValue)
        {
            Authors = athorManager.GetMatchedAuthors(SearchValue);
            PagingAuthors = PagedList<AuthorsVM>.Create(Authors.AsQueryable(), PageNumber, 12);

        }
    }
}
