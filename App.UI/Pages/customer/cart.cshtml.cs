using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.CartManager;
using App.UI.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SharedTenant.Domain;
using X.Paymob.CashIn;
using X.Paymob.CashIn.Models.Orders;
using X.Paymob.CashIn.Models.Payment;

namespace App.UI.Pages.customer
{
    public class cartModel : PageModel
    {
        private readonly GetBook getBook;
        private readonly IConfiguration configuration;
        private readonly UserManager<ApplicationUser> userManager;
        public Cart cart;
        public string userid; 
        public int IntegrationId;
        ApplicationUser applicationUser;
        private readonly IPaymobCashInBroker _broker;
        public string Iframe { get; set; }
        public cartModel(GetBook getBook, IConfiguration configuration,
            UserManager<ApplicationUser> UserManager,
            IPaymobCashInBroker broker)
        {
            cart = Cart.GetInstance();
            this.getBook = getBook;
            this.configuration = configuration;
            userManager = UserManager;
            IntegrationId = configuration.GetValue<int>("PaymobConfiguration:TestIntegrationId");
            _broker = broker;
        }
        public void OnGet(int Id = 0)
        {              
            userid = userManager.GetUserId(HttpContext.User);

            if (Id != 0)
            {
                if (!string.IsNullOrEmpty(userid))
                {
                    cart.DeleteItem(Id, userid);
                }
            }
        }
        public async Task OnPost(int TotalPrice)
        {
            // Create order.

            var orderRequest = CashInCreateOrderRequest.CreateOrder(TotalPrice*100);
            var orderResponse = await _broker.CreateOrderAsync(orderRequest);
            applicationUser = userManager.GetUserAsync(User).Result;

            // Request card payment key.
            var billingData = new CashInBillingData(
                firstName: applicationUser.UserName,
                lastName: applicationUser.NormalizedUserName,
                phoneNumber: applicationUser.PhoneNumber,
                email: applicationUser.Email);
                

            var paymentKeyRequest = new CashInPaymentKeyRequest(
                integrationId: IntegrationId,
                orderId: orderResponse.Id,
                billingData: billingData,
                currency:"EGP",
                amountCents: TotalPrice*100);

            var paymentKeyResponse = await _broker.RequestPaymentKeyAsync(paymentKeyRequest);

            // Create iframe src.
            Iframe= _broker.CreateIframeSrc(iframeId: "344931", token: paymentKeyResponse.PaymentKey);
            
        }

    }
}
