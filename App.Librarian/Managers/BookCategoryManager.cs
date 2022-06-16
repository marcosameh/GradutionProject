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
     public class BookCategoryManager
         {
        private readonly IMapper mapper;
        BaseRepo<BookCategory> CategoryRepo;
        public BookCategoryManager(KitabiContext context, IMapper mapper)
        {
            CategoryRepo = new BaseRepo<BookCategory>(context);

            this.mapper = mapper;
        }
        public List<BookCategoryVM> GetAllCategories()
        {
            var Categories = CategoryRepo.GetAll().OrderBy(x => x.Id).ToList();
            return mapper.Map<List<BookCategoryVM>>(Categories);

        }
        public void AddCategory(BookCategoryVM bookCategory)
        {
            var category = mapper.Map<BookCategory>(bookCategory);
            CategoryRepo.Add(category);
        }
        public BookCategoryVM GetCategoryById(int id)
        {
            var category = CategoryRepo.GetOne(a => a.Id == id);
            return mapper.Map<BookCategoryVM>(category);
        }

     
        public void DeleteCategory(int Id)
        {
            CategoryRepo.Delete(Id);


        }
        public void UpdateCategory(BookCategoryVM bookCategory)
        {
            var A = mapper.Map<BookCategory>(bookCategory);
            CategoryRepo.Edit(A);


        }


    }
}
