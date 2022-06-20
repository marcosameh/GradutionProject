using SharedTenant.SharedtenantReposatory;
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
        private readonly SharedtenantContext context;
        private readonly IMapper mapper;
        private SharedtenantBaseRebo<BooksForExchange> BooksForExchangeRepo;
        private SharedtenantBaseRebo<ExchangeBookCategoryList> CategoryListRepo;
        private SharedtenantBaseRebo<ExchangBookCategory> CategoryRepo;
        public ExchangeBookManger(SharedtenantContext context, IMapper mapper)
        {
            BooksForExchangeRepo = new SharedtenantBaseRebo<BooksForExchange>(context);
            CategoryListRepo = new SharedtenantBaseRebo<ExchangeBookCategoryList>(context);
            CategoryRepo = new SharedtenantBaseRebo<ExchangBookCategory>(context);
            this.context = context;
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
                OwnerId=BookVM.OwnerId,
                NumberOfCopies=BookVM.NumberOfCopies
                

            };

            BooksForExchangeRepo.Add(Book);
            BookVM.ExchageBookId = GetBookId(BookVM.Photo);
            foreach (var item in Categories)
            {
                var category = new ExchangeBookCategoryList { BookId = BookVM.ExchageBookId, CategroyId = item };

                CategoryListRepo.Add(category);
            }


        }
        public int GetBookId(string photo)
         {
             var book = BooksForExchangeRepo.GetOne(x => x.Photo == photo);
             return book.ExchageBookId;
         }
        public List<ExchangBookCategory> GetAllCategories()
        {
            return CategoryRepo.GetAll().ToList();
        }
        public List<ExchangeBookCategoryList> GetBookCategories(int bookid)
        {
            return CategoryListRepo.GetMany(book=>book.BookId==bookid,category=> category.Categroy).ToList();
        }
        public List<BooksForExchange> GetAllBooksByUser(string username)
        {
            return BooksForExchangeRepo.GetMany(book=>book.OwnerId.Equals(username )&& book.IsActive==true).ToList();
        }

        public List<ExchangeBookCategoryList> GetAllBookFromSameCategory(int Bookid)
        {
            int CategoryId = (int)CategoryListRepo.GetMany(book => book.BookId == Bookid).Select(category=>category.CategroyId).FirstOrDefault();
            var result = CategoryListRepo.GetMany(book => book.CategroyId == CategoryId && book.Book.IsActive == true, book => book.Book).OrderByDescending(last=>last.Id).Take(10).ToList();
            return result;
        }
        public List<BooksForExchange> GetAllExchangeBook()
        {
            return  BooksForExchangeRepo.GetMany(book => book.IsActive == true).ToList();
        }
        public IQueryable<BooksForExchange> GetWaitingBooks()
        {
            return BooksForExchangeRepo.GetMany(book => book.IsActive == false);
        }

        public void ApproveAll()
        {
            var Books = BooksForExchangeRepo.GetMany(x => x.IsActive == false).ToList();
            foreach (var item in Books)
            {
                item.IsActive = true;

            }
            foreach (var item in Books)
            {
                BooksForExchangeRepo.Edit(item);
            }
        }
        public BooksForExchange GetBook(string UrlName)
        {
            return BooksForExchangeRepo.GetOne(x => x.UrlName == UrlName);
        }
        public void Approve(string UrlName)
        {
            var Books = GetBook(UrlName);
          Books.IsActive = true;
            
                BooksForExchangeRepo.Edit(Books);
           
        }
        public void Delete(string UrlName)
        {
            var Book = GetBook(UrlName);
            context.BooksForExchange.Remove(Book);
            context.SaveChanges();
        }
    }
   
}
