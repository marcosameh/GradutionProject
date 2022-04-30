using App.Customer.ViewModel;
using AutoMapper;
using Microsoft.AspNetCore.Identity;
using SharedTenant.Domain;
using SharedTenant.Models;
using SharedTenant.SharedtenantReposatory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace App.Customer.RecommendedSystem
{
    public class CategoryList
    {
        public static List<int> FavouriteCategoryList =new List<int>();
    }
    public class RegisterPage2Manger
    {
        private readonly IMapper mapper;
        private readonly UserManager<ApplicationUser> userManager;
        private SharedtenantBaseRebo<ExchangBookCategory> bookCategoryRepo;
        private SharedtenantBaseRebo<CustomerLoveCategory> customerLoveCategoryRepo;

        public RegisterPage2Manger(SharedtenantContext context, IMapper mapper, UserManager<ApplicationUser> userManager)
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
            List<int> temp = new List<int>();
            temp.AddRange(CategoryList.FavouriteCategoryList);
            for (int i = 0; i < temp.Count; i++)
           {
                categoryItem = temp[i];
                foreach (var itemm in CategoryList.FavouriteCategoryList.Where(item=>item.Equals(categoryItem)))
                {
                    occurance++;
                }
                if(occurance %2==0)
                    CategoryList.FavouriteCategoryList.RemoveAll(item => item.Equals(categoryItem));
                else if(occurance % 2 == 1 && occurance > 1 )
                {
                    CategoryList.FavouriteCategoryList.RemoveAll(item => item.Equals(categoryItem));
                    CategoryList.FavouriteCategoryList.Insert(i, categoryItem) ;

                }
                occurance = 0;
            }
        }
        public async Task AddCustomerLoveCategory(string Customerid)
        {
            var user =await userManager.FindByIdAsync(Customerid);
            if(user!= null)
            {
                for (int i = 0; i < CategoryList.FavouriteCategoryList.Count; i++)
                {
                    var love = new CustomerLoveCategory()
                    {
                        CategoryId = CategoryList.FavouriteCategoryList[i],
                        CutomerId = Customerid
                    };
                    if (i < 1)
                        love.LoveRate = 4;
                    else if (i >= 1 && i < 2)
                        love.LoveRate = 3;
                    else if (i >= 2 && i < 4)
                        love.LoveRate = 2;
                    else
                        love.LoveRate = 1;
                    customerLoveCategoryRepo.Add(love);

                }
            }


        }
        public string ReturnCategoryList()
        {
            ManegeFavouriteCategoryList();
            string result = "";
            foreach (var item in CategoryList.FavouriteCategoryList)
            {
                var category = bookCategoryRepo.GetOne(category => category.CategoryId == item);
                result += category.CategoryName + " \\ ";
            }
            return result ;
        }
    }

}
