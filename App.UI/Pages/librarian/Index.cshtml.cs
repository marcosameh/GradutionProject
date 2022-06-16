using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.librarian
{
    [Authorize(Roles = "Librarian")]
    public class IndexModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
