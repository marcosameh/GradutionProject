using App.Core.Models;
using App.Core.Repositories;
using App.Librarian.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Librarian.Managers
{
     public class BookCategoryListManager
         {
        private readonly KitabiContext context;

        public BookCategoryListManager(KitabiContext context)
        {
            this.context = context;
        }
        public IQueryable<BookCategoryList> GetSlectedCategoriesIds(int Id)
        {
            return context.BookCategoryList.Where(x => x.BookId == Id);

        }

      
        public List<string> GetBookCategories(int bookid)
        {
            return context.BookCategoryList.Where(book => book.BookId == bookid).Select(book=>book.Category.CategoryName).ToList();

        }


    }
}
