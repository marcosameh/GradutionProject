using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace App.UI.Pages.author
{
    [Authorize(Roles = "Librarian")]

    public class DeleteModel : PageModel
    {
        private readonly AuthorManager athorManager;
        [BindProperty]
        public AuthorsVM Authors { get; set; }
        [BindProperty(SupportsGet =true)]
        public int Id { get; set; }

        public DeleteModel(AuthorManager athorManager)
        {
            this.athorManager = athorManager;
        }
        public void OnGet()
        {
            Authors = athorManager.GetAuthorById(Id);

        }
        public IActionResult OnPost()
        {
            athorManager.DeleteAuthor(Id);
            return Redirect("/author/list");
        }
    }
}
