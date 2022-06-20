using SharedTenant.Models;
using SharedTenant.SharedtenantReposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.RecommendedSystem
{
    public class RecommenedBooksManger
    {
        private SharedtenantBaseRebo<CustomerCategoryBookRate> CustomerCategoryBookRateRepo;
        private SharedtenantBaseRebo<CustomerRecomendedBook> CustomerRecomendedBookRepo;
        private SharedtenantBaseRebo<CustomerLoveCategory> CustomerLoveCategoryRepo;
        private SharedtenantBaseRebo<ExchangeBookCategoryList> CategoryListRepo;



        public RecommenedBooksManger(SharedtenantContext context)
        {
            CustomerCategoryBookRateRepo = new SharedtenantBaseRebo<CustomerCategoryBookRate>(context);
            CustomerRecomendedBookRepo = new SharedtenantBaseRebo<CustomerRecomendedBook>(context);
            CustomerLoveCategoryRepo = new SharedtenantBaseRebo<CustomerLoveCategory>(context);
            CategoryListRepo = new SharedtenantBaseRebo<ExchangeBookCategoryList>(context);


        }
        // this function is responsble for deploying Customer_Category__Book_Rate table in the database 
        private void DeployCustomer_Category__Book_Rate(string userid, int NumBooks)
        {

            // load customer favourite categories
            var FavoriteCategories = CustomerLoveCategoryRepo.GetMany(Customer => Customer.CutomerId.Equals(userid)).ToList();

            // returns last book occurance from a spacific category that belongs to a spacific customer
            var LastBookOccurance = CustomerCategoryBookRateRepo.GetMany(item => item.CustomerId.Equals(userid))
                .OrderByDescending(item => item.BookId)
                .FirstOrDefault();

            if (LastBookOccurance != null)
            {
                // returns a list of books that newley added to the system
                var NewBooksOccurance = CategoryListRepo.GetMany(b => b.BookId > LastBookOccurance.BookId).Take(NumBooks).ToList();
                if (NewBooksOccurance.Count != 0) { 
                    foreach (var book in NewBooksOccurance)

                    {

                        foreach (var FavouriteCategory in FavoriteCategories)
                        {
                            if (book.CategroyId == FavouriteCategory.CategoryId)
                            {
                                CustomerCategoryBookRateRepo.Add(new CustomerCategoryBookRate { BookId = book.BookId, CustomerId = userid, CategoryId = FavouriteCategory.CategoryId, LoveRate = FavouriteCategory.LoveRate * 4 });
                                break;

                            }
                        }
                    }
                }
            }
            else
            {
                var NewBooksOccurance = CategoryListRepo.GetAll().
                    Take(NumBooks).ToList();

                foreach (var book in NewBooksOccurance)

                {

                    foreach (var FavouriteCategory in FavoriteCategories)
                    {
                        if (book.CategroyId == FavouriteCategory.CategoryId)
                        {
                            CustomerCategoryBookRateRepo.Add(new CustomerCategoryBookRate { BookId = book.BookId, CustomerId = userid, CategoryId = FavouriteCategory.CategoryId, LoveRate = FavouriteCategory.LoveRate * 4 });
                            break;

                        }
                    }
                }
            }
        } 
        // this function is responsble for deploying CustomerRecommendedBook table in the database 

        private void DeployCustomerRecommendedBook(string userid,int NumBooks)
        {
            int bookID = 0;
            // makes sure that the list is not empty
            if(CustomerCategoryBookRateRepo.GetMany(id => id.CustomerId == userid).Count()!=0)
            {
                // returns a list of all books that the customer may like
            var Repo = CustomerCategoryBookRateRepo.GetMany(id => id.CustomerId == userid).ToList();
            foreach (var RepoItem in Repo.TakeLast(NumBooks))
            {
                    // sums love rate of every category in the book
                    // romance=4 - action=2 comedy=3
                    // total=9 there for the user may like this book by 9 degrees
                    // records this value to the CustomerRecomendedBook table
                if (RepoItem.BookId != bookID)
                {
                    bookID = (int)RepoItem.BookId;

                        // makes sure there are no dublicates
                    if (CustomerRecomendedBookRepo.GetOne(id => id.BookId == RepoItem.BookId && id.CustomerId.Equals(userid)) == null)
                    {
                        var totalRate = CustomerCategoryBookRateRepo.GetMany(id => id.CustomerId == userid && id.BookId == RepoItem.BookId).Sum(rate => rate.LoveRate);
                        CustomerRecomendedBookRepo.Add(new CustomerRecomendedBook { BookId = RepoItem.BookId, CustomerId = userid, LoveRate = totalRate });
                    }

                }
            }
        }

        }

        // Proccesses 5 books from each category for a spacific customer

        public void SetRecommenedBooks(string userid)
        {
            int NumBooks = 10;
            // Mutiblication phase
            DeployCustomer_Category__Book_Rate(userid, NumBooks);

            // summition phase
            DeployCustomerRecommendedBook(userid, NumBooks);
        }


        public List<CustomerRecomendedBook> GetRecommenedBooks(string userid,int NumBooks=0)
        {
            SetRecommenedBooks(userid);
            // Books Page
            if (NumBooks==0)
                return CustomerRecomendedBookRepo.GetMany(model => model.CustomerId == userid && model.Book.IsActive == true, book => book.Book).OrderByDescending(rate => rate.LoveRate).ToList();
            // Book Details Page
            return CustomerRecomendedBookRepo.GetMany(model => model.CustomerId == userid && model.Book.IsActive==true ,book=>book.Book).OrderByDescending(rate=>rate.LoveRate).Take(NumBooks).ToList();
        }
        public bool CustomerRegisterFavouriteCategories(string userid)
        {
            if (CustomerLoveCategoryRepo.GetMany(Customer => Customer.CutomerId.Equals(userid)).Count()!=0)
                return true;
            return false;
        }
    }
}
