﻿using App.Core.Manager;
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
        //public void AddBook(BookVM BookVM)
        //{
        //    BookVM.Photo = FileManager.UploadPhoto(BookVM.PhotoFile, "/wwwroot/photos/Books/", 150, 150);
        //    var Book = mapper.Map<Book>(BookVM);
        //    BookRepo.Add(Book);
        //}
        public void AddBook(BookVM BookVM)
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
        }
        public BookVM GetBookById(int id)
        {
            var book = BookRepo.GetOne(x => x.Id == id, x => x.Author);
            return mapper.Map<BookVM>(book);
             
        }
        public List<BookVM> GetfeaturedBooks()
        {

            var Book = BookRepo.GetMany(book => book.Offer != null && book.IsActive == true, book => book.Author).Take(take).ToList();
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
        public void UpdateBook(BookVM book)
        {
            var b = mapper.Map<Book>(book);   
            BookRepo.Edit(b);


        }

    }
}
