using App.Core.Manager;
using App.Core.Models;
using App.Core.Repositories;
using App.Librarian.ViewModels;
using AutoMapper;
using Korzh.EasyQuery.Linq;
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
        private readonly KitabiContext context;
        private readonly IMapper mapper;
        BaseRepo<Authors> AuthorRepo;
        BaseRepo<Book> AuthorBooksRepo;
        public AuthorManager(KitabiContext context, IMapper mapper)
        {
            AuthorRepo = new BaseRepo<Authors>(context);
            AuthorBooksRepo = new BaseRepo<Book>(context);
            this.context = context;
            this.mapper = mapper;
        }
        public List<AuthorsVM> GetAuthors()
        {
            var Authors = AuthorRepo.GetAll().OrderBy(x => x.DisplayOrder).ToList();
           return mapper.Map<List<AuthorsVM>>(Authors);
            
        }
        public List<AuthorsVM> GetMatchedAuthors(string SearchValue)
        {
            var Authors = context.Authors.FullTextSearchQuery(SearchValue);
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


        public AuthorsVM GetAuthorById(int id)
        {
            var Authors = AuthorRepo.GetOne(author => author.Id == id);
            return mapper.Map<AuthorsVM>(Authors);
        }
        public void DeleteAuthor(int Id)
        {
            AuthorRepo.Delete(Id);
        }
        public void UpdateAuthor(AuthorsVM author)
        {
            var A = mapper.Map<Authors>(author);
            AuthorRepo.Edit(A);
        }
        public List<BookVM> GetAuthorBooks(int authorid)
        {
            List<Book> authorBook = AuthorBooksRepo.GetMany(author => author.AuthorId == authorid).ToList();
            return mapper.Map<List<BookVM>>(authorBook);
            
        }
        

    }
}
