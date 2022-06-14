﻿using SharedTenant.SharedtenantReposatory;
using SharedTenant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Customer.ViewModel;
using AutoMapper;
using App.Core.Manager;

namespace App.Customer.RecommendedSystem
{
    public class ExchangeBookManger
    {
        private readonly IMapper mapper;
        private SharedtenantBaseRebo<BooksForExchange> BooksForExchangeRepo;
        private SharedtenantBaseRebo<ExchangeBookCategoryList> CategoryListRepo;
        private SharedtenantBaseRebo<ExchangBookCategory> CategoryRepo;
        public ExchangeBookManger(SharedtenantContext context, IMapper mapper)
        {
            BooksForExchangeRepo = new SharedtenantBaseRebo<BooksForExchange>(context);
            CategoryListRepo = new SharedtenantBaseRebo<ExchangeBookCategoryList>(context);
            CategoryRepo = new SharedtenantBaseRebo<ExchangBookCategory>(context);
            this.mapper = mapper;
        }
        public BookForExchangeVM GetBookByID( int ID)
        {
            var data = BooksForExchangeRepo.GetOne(book => book.ExchageBookId == ID);
            return mapper.Map< BookForExchangeVM >(data);

        }
        public void UploadBook(BookForExchangeVM BookVM, List<int> Categories)
        {
            BookVM.Photo = FileManager.UploadPhoto(BookVM.PhotoFile, "/wwwroot/photos/Books/", 150, 150);
            BooksForExchange Book = new BooksForExchange()
            {
                Name = BookVM.Name,
                Description=BookVM.Description,
                Photo=BookVM.Photo,
                AuthorName = BookVM.AuthorName,
                CopyYear = BookVM.CopyYear,
                IsActive = BookVM.IsActive,
                PdfUrl = BookVM.PdfUrl,
                AduioUrl = BookVM.AduioUrl,
                UrlName = BookVM.UrlName,
                OwnerId=BookVM.OwnerId

            };

            BooksForExchangeRepo.Add(Book);
            BookVM.ExchageBookId = GetBookId(BookVM.UrlName);
            foreach (var item in Categories)
            {
                var category = new ExchangeBookCategoryList { BookId = BookVM.ExchageBookId, CategroyId = item };

                CategoryListRepo.Add(category);
            }


        }
        public int GetBookId(string UrlName)
         {
             var book = BooksForExchangeRepo.GetOne(x => x.UrlName == UrlName);
             return book.ExchageBookId;
         }
        public List<ExchangBookCategory> GetAllCategories()
        {
            return CategoryRepo.GetAll().ToList();
        }
        public List<BooksForExchange> GetAllBooksByUser(string username)
        {
            return BooksForExchangeRepo.GetMany(book=>book.OwnerId.Equals(username)).ToList();
        }

    }
   
}
