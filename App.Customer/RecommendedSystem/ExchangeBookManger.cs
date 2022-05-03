using SharedTenant.SharedtenantReposatory;
using SharedTenant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Customer.ViewModel;
using AutoMapper;

namespace App.Customer.RecommendedSystem
{
    public class ExchangeBookManger
    {
        private readonly IMapper mapper;
        private SharedtenantBaseRebo<BooksForExchange> BooksForExchangeRepo;
        public ExchangeBookManger(SharedtenantContext context, IMapper mapper)
        {
            BooksForExchangeRepo = new SharedtenantBaseRebo<BooksForExchange>(context);
            this.mapper = mapper;
        }
        public BookForExchangeVM GetBookByID( int ID)
        {
            var data = BooksForExchangeRepo.GetOne(book => book.ExchageBookId == ID);
            return mapper.Map< BookForExchangeVM >(data);

        }
    }
}
