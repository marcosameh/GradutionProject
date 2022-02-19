using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using LazZiya.ImageResize;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.author
{
    [Authorize(Roles ="Librarian")]
    public class addModel : PageModel
    {
        private readonly AuthorManager authorManager;

        [BindProperty]
        public AuthorsVM Author { get; set; }
        public addModel(AuthorManager authorManager)
        {
            this.authorManager = authorManager;
        }
        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return OnGet();
            }
        
            authorManager.AddAuthor(Author);
            return Redirect("/author/list");
        }
    }
}
