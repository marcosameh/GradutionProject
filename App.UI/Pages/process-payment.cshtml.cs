using App.Customer.CartManager;
using App.UI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SharedTenant.Domain;
using System;
using X.Paymob.CashIn;
using X.Paymob.CashIn.Models.Callback;
using X.Paymob.CashIn.Models.Orders;
using X.Paymob.CashIn.Models.Payment;

namespace App.UI.Pages
{
    public class process_paymentModel : PageModelBase
    {
        private readonly IPaymobCashInBroker broker;
        private readonly UserManager<ApplicationUser> userManager;

        [BindProperty(SupportsGet = true)]
        public CashInCallbackTransaction CallBackData { get; set; }
        
        public ApplicationUser user { get; set; }
        public Cart cart;
        public int price;
        public string CreatedAdd;
        public process_paymentModel(IPaymobCashInBroker broker,UserManager<ApplicationUser> userManager)
        {
            this.broker = broker;
            this.userManager = userManager;

            cart = Cart.GetInstance();
            //al3b balah, 4bsi wkrtah, bozo bgnah, shittttttttttttttttttttttttttt

            // ENG. Peter was here
        }



        public void OnGet()
        {
            price = Convert.ToInt32(Request.Query["amount_cents"]);
            price = price / 100;
            CreatedAdd = Request.Query["created_at"];


            if (!CallBackData.Success)
            {
                

                Response.Redirect($"/error?msg=Payment Failed, Please try again");

                
          
            }
                
            user = userManager.GetUserAsync(HttpContext.User).Result;
        }

     
    }
}
