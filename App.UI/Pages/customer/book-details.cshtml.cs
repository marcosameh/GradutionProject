using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.customer
{
    public class book_detailsModel : PageModel
    {
        private readonly BookManager manger;
        public BookVM BookDetails;
        public List<BookVM >MostSellingBooks;
        public book_detailsModel(BookManager manger)
        {
            this.manger = manger;
        }
        public void OnGet(int Id)
        {
            BookDetails = manger.GetBookById(Id);
            MostSellingBooks = manger.GetMostSellingBook();
        }
    }
}
