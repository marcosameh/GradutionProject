using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.author
{
     [Authorize(Roles = "Librarian")]
    public class listModel : PageModel
    {
        private readonly AuthorManager athorManager;

        public List<AuthorsVM> Authors;
        public listModel(AuthorManager athorManager)
        {
            this.athorManager = athorManager;
        }
        public void OnGet()
        {
            Authors = athorManager.GetAuthors();
        }
        public IActionResult OnGetDisplayAuthors()
        {
            Authors = athorManager.GetAuthors();
            return new JsonResult(Authors);
        }
    }
}
