using App.Core.Models;
using App.Librarian.ViewModels;
using AutoMapper;

namespace App.Librarian.AutoMapper
{
    public class DominProfile : Profile
    {
        public DominProfile()
        {
            CreateMap<Authors, AuthorsVM>().ReverseMap();
        }
    }
       
}
