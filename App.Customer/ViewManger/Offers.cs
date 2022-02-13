using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.ViewManger
{
    public class Offers
    {
        private readonly KitabiContext context;
        private BaseRepo<Book> repo;
        private Paging page;
         

        
        public Offers(KitabiContext context)
        {
            this.context = context;
            repo = new BaseRepo<Book>(context);
           
        }
        public Offers(KitabiContext context, int BookPerPage)
        {
            this.context = context;
            repo = new BaseRepo<Book>(context);
            page = new Paging(BookPerPage);
        }

        public IQueryable<Book> GetOfferedBooks(int CurrentPage)
        {
            int BooksCount = CountOfferedBooks();

             int skip = page.SkipNumBooks(CurrentPage);
            if (BooksCount == 0)
                return null;
            
            return repo.GetMany(book => book.Offer != null && book.IsApproved == true && book.IsActive == true,book=>book.Author)
                .Skip(skip).Take(page.ItemPerPage);
        }
        public IQueryable<Book> GetfeaturedBooks( int bookNumber)
        {
            int BooksCount = CountOfferedBooks();

           
            if (BooksCount == 0)
                return null;

            return repo.GetMany(book => book.Offer != null && book.IsApproved == true && book.IsActive == true, book => book.Author).Take(bookNumber);
                
        }

        public  int CountOfferedBooks()
        {

            return repo.GetAll().Count();
        }

        public int GetNumOfPages()
        {
          return  page.GetNumOfPages();
        }
    }
}
