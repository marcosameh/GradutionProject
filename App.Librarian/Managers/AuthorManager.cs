using App.Core.Manager;
using App.Core.Models;
using App.Core.Repositories;
using App.Librarian.ViewModels;
using AutoMapper;
using LazZiya.ImageResize;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Librarian.Managers
{

    public class AuthorManager
    {
        private readonly IMapper mapper;
        BaseRepo<Authors> AuthorRepo;
        public AuthorManager(KitabiContext context, IMapper mapper)
        {
            AuthorRepo = new BaseRepo<Authors>(context);
            this.mapper = mapper;
        }
        public List<AuthorsVM> GetAuthors()
        {
            var Authors = AuthorRepo.GetAll().OrderBy(x => x.DisplayOrder).ToList();
           return mapper.Map<List<AuthorsVM>>(Authors);
            
        }

        public int GetAuthorsCount()
        {
            var Authors = AuthorRepo.GetAll().Count();
            return Authors;

        }

        public void AddAuthor(AuthorsVM author)
        {
            author.Photo = FileManager.UploadPhoto(author.PhotoFile, "/wwwroot/photos/author/", 150, 150);
            var Author = mapper.Map<Authors>(author);
            AuthorRepo.Add(Author);
        }

    }
}
