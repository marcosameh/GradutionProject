using App.Core.Manager;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SharedTenant.Manager;
using SharedTenant.Models;

namespace App.UI.Pages.Bookstores
{
    [Authorize(Roles="Admin")]
    public class EditModel : PageModel
    {
        private readonly CurrentTenantManager bookStoreManager;

        [BindProperty]
        public BookStores BookStore { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }
        public EditModel(CurrentTenantManager BookStoreManager )
        {
            bookStoreManager = BookStoreManager;
        }
        public void OnGet()
        {
            BookStore=bookStoreManager.GetBookStore(Id);
        }
        public IActionResult OnPost()
        {
            if (BookStore.PhotoFile==null)
            {
                bookStoreManager.EditBookStore(BookStore);

                return Redirect("/Bookstores/list");
            }
            BookStore.Logo = FileManager.UploadPhoto(BookStore.PhotoFile, "/wwwroot/photos/librarian/", 90, 90);
            bookStoreManager.EditBookStore(BookStore);

            return Redirect("/Bookstores/list");
        }
    }
}
