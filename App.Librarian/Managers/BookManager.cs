using App.Core.Manager;
using App.Core.Models;
using App.Core.Repositories;
using App.Librarian.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using Korzh.EasyQuery.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace App.Librarian.Managers
{
    public class BookManager

    {
        private readonly KitabiContext context;
        private readonly IMapper mapper;
        BaseRepo<Book> BookRepo;
        BaseRepo<BookCategoryList> CategoryListRepo;
        private int take=10;
        public BookManager(KitabiContext context, IMapper mapper)
        {
            BookRepo = new BaseRepo<Book>(context);
            CategoryListRepo = new BaseRepo<BookCategoryList>(context);
            this.context = context;
            this.mapper = mapper;
        }
        public List<BookVM> GetAllBooks()
        {
            var book = BookRepo.GetMany(null, book => book.Author).OrderBy(x => x.Id).ToList();

            return mapper.Map<List<BookVM>>(book);
        }
        public List<BookVM> GetMatchedBooks(string SearchValue)
        {
            var book = BookRepo.GetMany(x=>x.Name.Contains(SearchValue)||x.Description.Contains(SearchValue)||x.Author.Name.Contains(SearchValue), book => book.Author).OrderBy(x => x.Id).ToList();

            return mapper.Map<List<BookVM>>(book);
        }
        public int GetBooksCount()
        {
            var book = BookRepo.GetAll().Count();
            return book;

        }
        //public void AddBook(BookVM BookVM)
        //{
        //    BookVM.Photo = FileManager.UploadPhoto(BookVM.PhotoFile, "/wwwroot/photos/Books/", 150, 150);
        //    var Book = mapper.Map<Book>(BookVM);
        //    BookRepo.Add(Book);
        //}

        public int GetBookId(string UrlName)
        {
           var book = BookRepo.GetOne(x => x.UrlName == UrlName);
            return book.Id;
        }
        public void AddBook(BookVM BookVM,List<int> CategoryIds)
        {
            BookVM.Photo = FileManager.UploadPhoto(BookVM.PhotoFile, "/wwwroot/photos/Books/", 150, 150);
            //   var Book = mapper.Map<Book>(BookVM);
            var book = new Book
            {
                
                Name = BookVM.Name,

   
                UrlName = BookVM.UrlName,
                AuthorId = BookVM.AuthorId,
                Description = BookVM.Description,
                NumberOfCopies = BookVM.NumberOfCopies,
                Price = BookVM.Price,

                Offer = BookVM.Offer,
                PdfUrl = BookVM.PdfUrl,
                AduioUrl = BookVM.AduioUrl,

              
                Photo = BookVM.Photo,
                CopyYear = BookVM.CopyYear,
                IsActive = BookVM.IsActive,

            };
            BookRepo.Add(book);
            BookVM.Id = GetBookId(BookVM.UrlName);
            foreach (var item in CategoryIds)
            {
                var category = new BookCategoryList { BookId = BookVM.Id, CategoryId = item };

                CategoryListRepo.Add(category);
            }
          
            
        }
        public BookVM GetBookById(int id)
        {
            var book = BookRepo.GetOne(x => x.Id == id, x => x.Author);
            return mapper.Map<BookVM>(book);
             
        }
        public List<BookVM> GetfeaturedBooks()
        {

            var Book = BookRepo.GetMany(book => book.Offer != null && book.IsActive == true && book.Offer!=0, book => book.Author).Take(take).ToList();
            return mapper.Map<List<BookVM>>(Book);
        }
        public List<BookVM> GetMostSellingBook()
        {

            var Book = BookRepo.GetAll().OrderByDescending(book => book.NumSells).Take(take).ToList();
            return mapper.Map<List<BookVM>>(Book);
        }
        public List<BookVM> GetNewArrivalls()
        {
            var Book = BookRepo.GetAll().OrderByDescending(book=>book.Id).ToList();
            return mapper.Map<List<BookVM>>(Book);

        }
        public void DeleteBook(int Id)
        {
            BookRepo.Delete(Id);


        }
        public void UpdateBook(BookVM book, List<int> CategoryIds)
        {
            var b = mapper.Map<Book>(book);   
            BookRepo.Edit(b);
           

            foreach (var item in CategoryIds)
            {
                var category = new BookCategoryList { BookId = book.Id, CategoryId = item };

                CategoryListRepo.Edit(category);
            }


        }
        public List<BookCategoryList> GetAllBookFromSameCategory(int Bookid)
        {
            int CategoryId = CategoryListRepo.GetMany(book => book.BookId == Bookid).Select(C=>C.CategoryId).FirstOrDefault();
            
            var result = CategoryListRepo.GetMany(book => book.CategoryId == CategoryId, book => book.Book).OrderByDescending(last => last.BookId).Take(10).ToList();
            return result;
        }
    }
}
