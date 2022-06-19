using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.UI.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Models;

namespace App.UI.Pages.customer
{
    public class recommened_booksModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManger;
        public List<CustomerRecomendedBook> recomendedBooks;
        public PagedList<CustomerRecomendedBook> PagingBooks { get; set; }
        [FromQuery(Name = "page")]
        public int PageNumber { get; set; } = 1;

        public RecommenedBooksManger recommenedBooksManger { get; set; }
        public recommened_booksModel(UserManager<ApplicationUser> userManger,
        RecommenedBooksManger recommenedBooksManger)
        {
            this.userManger = userManger;
            this.recommenedBooksManger = recommenedBooksManger;
        }
        public void OnGet()
        {  
            var userid = userManger.GetUserId(HttpContext.User);
                if(userid != null)
            {
                recomendedBooks = recommenedBooksManger.GetRecommenedBooks(userid, 0);

            }

            PagingBooks = PagedList<CustomerRecomendedBook>.Create(recomendedBooks.AsQueryable(), PageNumber, 12
                    );



           

        }
       
    }
}

