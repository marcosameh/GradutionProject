using App.Core.Models;
using App.Librarian.ViewModels;
using AutoMapper;

namespace App.Librarian.AutoMapper
{
    public class DominProfile : Profile
    {
        public DominProfile()
        {
            CreateMap<Book, BookVM>().ReverseMap();
            CreateMap<Authors, AuthorsVM>().ReverseMap();
            CreateMap<BookCategory, BookCategoryVM>().ReverseMap();


        }
    }
       
}
