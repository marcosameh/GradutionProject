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

        public RecommenedBooksManger(SharedtenantContext context)
        {
            CustomerCategoryBookRateRepo = new SharedtenantBaseRebo<CustomerCategoryBookRate>(context);
            CustomerRecomendedBookRepo = new SharedtenantBaseRebo<CustomerRecomendedBook>(context);

        }
        public void SetRecommenedBooks(string userid)
        {
            
            int bookID = 0;
                var BookIDs= CustomerCategoryBookRateRepo.GetMany(id => id.CustomerId == userid ).Select(book=>book.BookId).ToList();
                foreach (var bookId in BookIDs)
                {
                    if(bookId!=bookID)
                    {
                    bookID = (int)bookId;
                    if (CustomerRecomendedBookRepo.GetOne(id => id.BookId == bookId) == null)
                    {

                        var totalRate = CustomerCategoryBookRateRepo.GetMany(id => id.CustomerId == userid && id.BookId == bookId).Sum(rate => rate.LoveRate);
                        CustomerRecomendedBookRepo.Add(new CustomerRecomendedBook { BookId=bookId,CustomerId=userid,LoveRate= totalRate });
                    }
                    
                }
            }

        }
        public List<CustomerRecomendedBook> GetRecommenedBooks(string userid)
        {
            return CustomerRecomendedBookRepo.GetMany(model => model.CustomerId == userid ,book=>book.Book).OrderByDescending(rate=>rate.LoveRate).Take(10).ToList();
        }
    }
}
