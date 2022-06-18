using App.Core.Manager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Domain;
using SharedTenant.Manager;
using SharedTenant.Models;
using System.Threading.Tasks;

namespace App.UI.Pages.Bookstores
{
    [Authorize(Roles="Admin")]
    public class AddModel : PageModel
    {
        private readonly CurrentTenantManager BookStoreManager;
        private readonly UserManager<ApplicationUser> _userManager;

        [BindProperty]
        public BookStores BookStore { get; set; }
        public AddModel(CurrentTenantManager currentTenantManager,UserManager<ApplicationUser> UserManager)
        {
           
            this.BookStoreManager = currentTenantManager;
            this._userManager = UserManager;
        }

        public void OnGet()
        {
        }
        public async Task<IActionResult> OnPostAsync()
        {
            BookStore.Logo = FileManager.UploadPhoto(BookStore.PhotoFile, "/wwwroot/photos/librarian/", 90, 90);
            var user = new ApplicationUser { UserName = BookStore.Email, Email = BookStore.Email, Photo = BookStore.Logo };

            var result = await _userManager.CreateAsync(user, BookStore.Password);
            if (result.Succeeded)
            {
                user.EmailConfirmed = true;
              

               
                BookStoreManager.AddBookStore(BookStore);
              
            }
            return Redirect("/Bookstores/list");
        }
    }
}
