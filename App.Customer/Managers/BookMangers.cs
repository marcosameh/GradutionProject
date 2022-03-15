using App.Core.Models;
using App.Core.Repositories;
using App.Customer.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.Managers
{
    public class BookMangers
    {
        private readonly KitabiContext context;
        private BaseRepo<Book> repo;
        private Paging page;
        public BookMangers(KitabiContext context)
        {
            this.context = context;
            repo = new BaseRepo<Book>(context);


        }

        // returns books with paging
        public List<Book> GetOfferedBooks(int CurrentPage)
        {
            int NumOfBookPerPage = 16;
            page = new Paging(NumOfBookPerPage);
            int skip = page.SkipNumBooks(CurrentPage);
            return repo.GetMany(book => book.Offer != null && book.IsActive == true, book => book.Author)
                .Skip(skip).Take(page.ItemPerPage).ToList();
        }


        // get featured books in home page

        public List<Book> GetfeaturedBooks(int TakeNumberOfBooks)
        {

            return repo.GetMany(book => book.Offer != null && book.IsActive == true, book => book.Author).Take(TakeNumberOfBooks).ToList();

        }

        public int CountOfferedBooks()
        {
            return repo.GetMany(book => book.Offer != null && book.IsActive == true, book => book.Author).Count();
        }

        public int GetNumOfPages()
        {
            return page.GetNumOfPages();
        }

        // get new arrival books in home page
        public List<Book> GetNewArrivalls(int take)
        {
            return repo.GetAll().Take(take).ToList();
        }
    }
}
