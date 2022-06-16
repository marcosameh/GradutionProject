using App.Customer.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SharedTenant.Domain;
using SharedTenant.Models;
using SharedTenant.SharedtenantReposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Customer.RecommendedSystem
{
    public class CategoryListItems
    {
        public int CategoryID { get; set; }
        public int LoveRate { get; set; }
    }
    public class CategoryList
    {
        public static List<CategoryListItems> FavouriteCategoryList =new List<CategoryListItems>();
    }
    public class RegisterFavouriteCategoryManger
    {
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private SharedtenantBaseRebo<ExchangBookCategory> bookCategoryRepo;
        private SharedtenantBaseRebo<CustomerLoveCategory> customerLoveCategoryRepo;


        public RegisterFavouriteCategoryManger(SharedtenantContext context, IMapper mapper, UserManager<ApplicationUser> userManager)
        {
            bookCategoryRepo = new SharedtenantBaseRebo<ExchangBookCategory>(context);
            customerLoveCategoryRepo = new SharedtenantBaseRebo<CustomerLoveCategory>(context);


            this.mapper = mapper;
            this.userManager = userManager;
        }
        public List<ExchangeBookCategoryVM> GetAllBookCategories()
        {
            var categories=bookCategoryRepo.GetAll();
            return mapper.Map<List<ExchangeBookCategoryVM>>(categories);
        }
        private void ManegeFavouriteCategoryList()
        {
            int occurance = 0;
            int categoryItem = 0;
            List<CategoryListItems> temp = new List<CategoryListItems>();
            temp.AddRange(CategoryList.FavouriteCategoryList);
            for (int i = 0; i < temp.Count; i++)
           {
                categoryItem = temp[i].CategoryID;
                foreach (var itemm in CategoryList.FavouriteCategoryList.Where(item=>item.CategoryID ==categoryItem))
                {
                    occurance++;
                }
                if(occurance %2==0)
                    CategoryList.FavouriteCategoryList.RemoveAll(item => item.CategoryID == categoryItem);
                else if(occurance % 2 == 1 && occurance > 1 )
                {
                    CategoryList.FavouriteCategoryList.RemoveAll(item => item.CategoryID == categoryItem);
                    CategoryList.FavouriteCategoryList.Insert(i, new CategoryListItems { CategoryID= categoryItem }) ;

                }
                occurance = 0;
            }
        }
        public void AddCustomerLoveCategory(int categoryID)
        { CategoryList.FavouriteCategoryList.Add(new CategoryListItems { CategoryID=categoryID});
        }
        public async Task AddCustomerLoveCategory(string Customerid)
        {
            var user =await userManager.FindByIdAsync(Customerid);
            if(user!= null)
            {
                for (int i = 0; i < CategoryList.FavouriteCategoryList.Count; i++)
                {

                    int CategoryId = CategoryList.FavouriteCategoryList[i].CategoryID;
                    
                    
                    if (i < 1)
                        CategoryList.FavouriteCategoryList[i].LoveRate = 4;
                    else if (i >= 1 && i < 2)
                        CategoryList.FavouriteCategoryList[i].LoveRate = 3;
                    else if (i >= 2 && i < 4)
                        CategoryList.FavouriteCategoryList[i].LoveRate = 2;
                    else
                        CategoryList.FavouriteCategoryList[i].LoveRate = 1;
                    int LoveRate = CategoryList.FavouriteCategoryList[i].LoveRate;
                    customerLoveCategoryRepo.Add(new CustomerLoveCategory { CutomerId= Customerid ,CategoryId= CategoryId ,LoveRate= LoveRate });
                }
                CategoryList.FavouriteCategoryList.Clear();
            }

        }
        //// this function is responsble for deploying Customer_Category__Book_Rate table in the database 
        //private void DeployCustomer_Category__Book_Rate(int CategryID, string customerID, int LoveRate)
        //{
        //    var BookIDs = CategoryListRepo.GetMany(ID => ID.CategroyId == CategryID).Select(item => item.BookId).ToList();
        //    foreach (var bookid in BookIDs)
        //    {
        //        CustomerCategoryBookRateRepo.Add(new CustomerCategoryBookRate { BookId = bookid, CustomerId = customerID, CategoryId = CategryID, LoveRate = LoveRate * 4 });
        //    }
        //}

        public string ReturnCategoryList()
        {
            ManegeFavouriteCategoryList();
            string result = "";
            foreach (var item in CategoryList.FavouriteCategoryList)
            {
                var category = bookCategoryRepo.GetOne(category => category.CategoryId == item.CategoryID);
                result += category.CategoryName + " \\ ";
            }
            return result ;
        }
        public void UpdateInterest(string userid)
        {
            try
            {
            customerLoveCategoryRepo.ExecProcidure("UpdateInterest",userid);

            }catch(Exception ex)
            {

            }
        }
    }

}
