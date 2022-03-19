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
        private readonly CurrentTenantManager connectionManger;
        public List<AuthorsVM> Authors;
        public PagedList<AuthorsVM> PagingAuthors { get; set; }
        public AuthorsModel(AuthorManager athorManager,CurrentTenantManager ConnectionManger)
        {
            connectionManger = ConnectionManger;
            this.athorManager = athorManager;
          
        }


        public void OnGet([FromQuery]int Page=1)
        {

           
            Authors = athorManager.GetAuthors();
            PagingAuthors = PagedList<AuthorsVM>.Create(Authors.AsQueryable(), Page, 5);


        }
    }
}
