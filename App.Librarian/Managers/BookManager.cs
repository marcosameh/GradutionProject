using App.Core.Manager;
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
    public class BookManager
    {
        private readonly IMapper mapper;
        BaseRepo<Book> BookRepo;
        private int take=10;
        public BookManager(KitabiContext context, IMapper mapper)
        {
            BookRepo = new BaseRepo<Book>(context);

            this.mapper = mapper;
        }
        public List<BookVM> GetAllBooks()
        {
            var book = BookRepo.GetMany(null, book => book.Author).OrderBy(x => x.Id).ToList();
            return mapper.Map<List<BookVM>>(book);
        }
        public int GetBooksCount()
        {
            var book = BookRepo.GetAll().Count();
            return book;

        }
        public void AddBook(BookVM BookVM)
        {
            BookVM.Photo = FileManager.UploadPhoto(BookVM.PhotoFile, "/wwwroot/photos/Books/", 150, 150);
            var Book = mapper.Map<Book>(BookVM);
            BookRepo.Add(Book);
        }
        public BookVM GetBookById(int id)
        {
            var book = BookRepo.GetOne(x => x.Id == id,x=>x.Author);
            return mapper.Map<BookVM>(book);
             
        }
        public List<BookVM> GetfeaturedBooks()
        {

            var Book = BookRepo.GetMany(book => book.Offer != null && book.IsActive == true, book => book.Author).Take(take).ToList();
            return mapper.Map<List<BookVM>>(Book);
        }
        public List<BookVM> GetMostSellingBook()
        {

            var Book = BookRepo.GetAll().OrderByDescending(book=>book.NumSells).Take(take).ToList();
            return mapper.Map<List<BookVM>>(Book);
        }
        public List<BookVM> GetNewArrivalls()
        {
            var Book = BookRepo.GetAll().OrderByDescending(book=>book.Id).ToList();
            return mapper.Map<List<BookVM>>(Book);

        }
        public void DeleteBook(int Id )
        {
            BookRepo.Delete(Id);    
 

        }

    }
}
