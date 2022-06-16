using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Customer.WishlistManger;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;

namespace App.UI.Pages.customer
{
    [Authorize(Roles = "Customer")]
    public class wishlistModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly WishlistCRUD wishlist;
        public List<WishlistVM> MyWishlist;
        public string userid;

        public wishlistModel(
            UserManager<ApplicationUser> UserManager,
            WishlistCRUD wishlist
            )
        {
            userManager = UserManager;
            this.wishlist = wishlist;
        }
        public void OnGet(int Id = 0)
        {
            userid = userManager.GetUserId(HttpContext.User);

            if (Id != 0)
            {

                wishlist.DeleteWish(Id);
            }
            MyWishlist = wishlist.GetAllWishes(userid);

        }
        
    }
}
