using App.Core.Models;
using App.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.Views
{
    public class SectionView
    {
        private readonly KitabiContext db;
        private BaseRepo<BookCategory> bookCategoryRepo;
        private BaseRepo<BookCategoryList> bookCategoryListRepo;
        public List<NumBooksInCategory> numBooksInCategory;
        


        public SectionView(KitabiContext db)
        {
            this.db = db;
            bookCategoryRepo = new BaseRepo<BookCategory>(db);
            bookCategoryListRepo = new BaseRepo<BookCategoryList>(db);
        }
        public List<NumBooksInCategory> GetCategoriesDetails()
        {
            List < NumBooksInCategory > list=new List<NumBooksInCategory>();
            var Category = bookCategoryRepo.GetAll().ToList();
            foreach (var item in Category)
            {
                list.Add(new NumBooksInCategory
                {
                    categoryName = item.CategoryName,
                    NumBooks = bookCategoryListRepo.GetMany(a => a.CategoryId == item.Id).Count()
                }); 
            }
            return list;
        }

        

    }
    public class NumBooksInCategory
    {
        public string categoryName{ get; set; }
        public int NumBooks{ get; set; }

    }
}
