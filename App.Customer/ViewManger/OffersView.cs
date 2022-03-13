using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.ViewManger
{
    public class OffersView
    {
        private readonly KitabiContext context;
        private BaseRepo<Book> repo;
        private Paging page;

        public OffersView(KitabiContext context)
        {
            this.context = context;
            repo = new BaseRepo<Book>(context);
            

        }

        public IQueryable<Book> GetOfferedBooks(int CurrentPage)
        {
            page = new Paging(16);
            int skip = page.SkipNumBooks(CurrentPage);                        
            return repo.GetMany(book => book.Offer != null && book.IsActive == true,book=>book.Author)
                .Skip(skip).Take(page.ItemPerPage);
        }

        
        // get featured books in home page
        public IQueryable<Book> GetfeaturedBooks( int bookNumber)
        {

            return repo.GetMany(book => book.Offer != null  && book.IsActive == true, book => book.Author).Take(bookNumber);
                
        }

        public  int CountOfferedBooks()
        {
            return repo.GetMany(book => book.Offer != null && book.IsActive == true, book => book.Author).Count();
        }

        public int GetNumOfPages()
        {
          return  page.GetNumOfPages();
        }
    }
}
