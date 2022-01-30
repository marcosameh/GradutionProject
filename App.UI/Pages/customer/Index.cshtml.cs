using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.Customer
{
    [Authorize(Roles = "Customer")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
