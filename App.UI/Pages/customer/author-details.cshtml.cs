using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Core.Models;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class author_detailsModel : PageModel
    {
        private readonly AuthorManager manger;
        public AuthorsVM author;
        public List<BookVM> AuthorBooks;
        public author_detailsModel(AuthorManager manger)
        {
            this.manger = manger;
        }
        public void OnGet(int Id)
        {
            author = manger.GetAuthorById(Id);
            AuthorBooks = manger.GetAuthorBooks(Id);
        }
    }
}
