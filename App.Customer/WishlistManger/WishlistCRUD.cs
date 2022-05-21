using SharedTenant.SharedtenantReposatory;
using SharedTenant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Customer.ViewModel;
using AutoMapper;

namespace App.Customer.WishlistManger
{
    public class WishlistCRUD
    {
        private readonly IMapper mapper;
        private SharedtenantBaseRebo<Wishlist> WishlistRepo;
        public WishlistCRUD(SharedtenantContext context, IMapper mapper)
        {
            WishlistRepo = new SharedtenantBaseRebo<Wishlist>(context);
            this.mapper = mapper;
        }
        public void AddToWishlist(WishlistVM wishlist)
        {
            var wList = mapper.Map<Wishlist>(wishlist);
            WishlistRepo.Add(wList);
        }
        public void DeleteWish(int wishID)
        {
            WishlistRepo.Delete(wishID);
        }
        public List<WishlistVM> GetAllWishes(string CustomerID)
        {
            var data = WishlistRepo.GetMany(Customer => Customer.CustomerId.Equals(CustomerID));

            return mapper.Map < List<WishlistVM> >(data);
        }
        public int FindWish(string CustomerID,string Bookstore,int BookID)
        {
            var result = WishlistRepo.GetOne(wish => wish.CustomerId.Equals(CustomerID) && wish.BookStore.Equals(Bookstore) && wish.BookId==BookID);
            if (result != null)
                return result.WishId;
            return 0;

        }
    }
}
