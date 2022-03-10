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
        public BookManager(KitabiContext context , IMapper mapper)
        {
            BookRepo = new BaseRepo<Book>(context);

            this.mapper = mapper;
        }
        public List<BookVM> GetAllBooks()
        {
            var book = BookRepo.GetMany(null,book=>book.Author).OrderBy(x => x.Id).ToList();
            return mapper.Map<List<BookVM>>(book);
        }
        public int GetBooksCount()
        {
            var book = BookRepo.GetAll().Count();
            return book;

        }
        public void AddBook(BookVM book)
        {
            book.BookPhoto = FileManager.UploadPhoto(book.PhotoFile, "/wwwroot/photos/Books/", 150, 150);
            var Book  = mapper.Map<Book>(book);
            BookRepo.Add(Book);
        }
        public BookVM GetBookById(int id)
        {
            var book = BookRepo.GetOne(x => x.Id == id);
            return mapper.Map<BookVM>(book);
        }
    }
}
