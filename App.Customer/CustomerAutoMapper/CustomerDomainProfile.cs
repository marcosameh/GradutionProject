using App.Customer.ViewModel;
using App.Customer.WishlistManger;
using AutoMapper;
using SharedTenant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Customer.CustomerAutoMapper
{
    public class CustomerDomainProfile : Profile
    {
        public CustomerDomainProfile()
        {
        CreateMap<ExchangBookCategory, ExchangeBookCategoryVM>().ReverseMap();
            CreateMap<BooksForExchange, BookForExchangeVM>().ReverseMap();
            CreateMap<Wishlist, WishlistVM>().ReverseMap();


        }

    }
}
