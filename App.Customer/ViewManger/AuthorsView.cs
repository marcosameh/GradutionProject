using App.Core.Models;
using App.Core.Repositories;
using App.Librarian.ViewModels;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.ViewManger
{
    public class AuthorsView
    {
        private readonly IMapper mapper;
        BaseRepo<Authors> AuthorRepo;
        public Paging paging;

        public int PageIndex { get;  set; }

        public AuthorsView(KitabiContext context, IMapper mapper)
        {
            AuthorRepo = new BaseRepo<Authors>(context);
            this.mapper = mapper;
            paging = new Paging(16);
            paging.ItemNum = GetAuthorsCount();
        }
        public int GetAuthorsCount()
        {
            int Authors = AuthorRepo.GetAll().Count();
            return Authors;

        }
        public List<AuthorsVM> GetAuthors()
        {
            var Authors = AuthorRepo.GetAll().OrderBy(x => x.DisplayOrder).Skip(paging.SkipNumBooks(PageIndex)).Take(16).ToList();
            return mapper.Map<List<AuthorsVM>>(Authors);

        }
    }
}
