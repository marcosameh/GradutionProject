using App.Core.Manager;
using App.Librarian.Managers;
using App.Librarian.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.UI.Pages.author
{
    public class UpdateModel : PageModel
    {
        private readonly AuthorManager author;
        [BindProperty(SupportsGet =true)]
        public AuthorsVM Authors { get; set; }
       

        public UpdateModel(AuthorManager Author)
        {
            author = Author;
        }
        public void OnGet( int id)
        {
            Authors = author.GetAuthorById(id);   
        }
        public void OnPost()
        {
            if (Authors.PhotoFile != null)
            {
                Authors.Photo = FileManager.UploadPhoto(Authors.PhotoFile, "/wwwroot/photos/author/", 150, 150);
            }
            author.UpdateAuthor(Authors);
        }
    }
}
