using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using App.Customer.RecommendedSystem;
using App.Customer.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.Account
{
    public class RegisterPage2Model : PageModel
    {
        private readonly RegisterFavouriteCategoryManger manger;
        public List<ExchangeBookCategoryVM> bookCategories;

        [BindProperty(SupportsGet =true)]
        public string handler { get; set; }
        public RegisterPage2Model(RegisterFavouriteCategoryManger manger)
        {
            this.manger = manger;
        }
        public void OnGet(string id)
        {
            bookCategories = manger.GetAllBookCategories();
            if(!string.IsNullOrEmpty(handler) && handler.Equals("ResetIntersets"))
            {
                manger.UpdateInterest(id);
            }

        }
        public async Task<IActionResult> OnPost(string id)
        {
            bookCategories = manger.GetAllBookCategories();
            if (CategoryList.FavouriteCategoryList.Count <= 2)
            {
                ModelState.AddModelError("", "WARNNING : must select atleast 2 categories");
                return Page();

            }

            await manger.AddCustomerLoveCategory(id);
            if (!string.IsNullOrEmpty(handler) && handler.Equals("ResetIntersets"))
            {
                return Redirect("/index");
            }
            return Redirect("/Account/Login");
        }
        public void OnGetSetCategoryList(int labelID)
        {
            manger.AddCustomerLoveCategory(labelID);
        }
        public JsonResult OnGetReturnCategoryList()
        {
            return new JsonResult(manger.ReturnCategoryList() );
        }
    }
}
