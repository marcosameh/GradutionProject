using SharedTenant.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Linq;
using Korzh.EasyQuery.Linq;

namespace SharedTenant.Manager
{
    public class CurrentTenantManager
    {



        private readonly IHttpContextAccessor Accessor;
        private readonly SharedtenantContext SharedtenantContext;
        private readonly string UrlName;

        public CurrentTenantManager(IHttpContextAccessor Accessor, SharedtenantContext sharedtenantContext,string UrlName)
        {
            this.Accessor = Accessor;
            this.SharedtenantContext = sharedtenantContext;
            this.UrlName = UrlName;
        }
        public BookStores GetCurrentBookStore()
        {
            
            var result= SharedtenantContext.BookStores.Where(x => x.UrlName == UrlName).FirstOrDefault();
            if(result==null)
            {
            var CurrentDomin = Accessor.HttpContext.Request.Host.Value;          
            foreach (var domin in GetDomins())
            {
                if (domin == CurrentDomin  /*&&CurrentDomin != "localhost:44381"*/)
                {
                    return SharedtenantContext.BookStores.Where(x => x.Domain == CurrentDomin).FirstOrDefault();
                }

            }
            }

            return result;


        }
    
        public IQueryable<BookStores> GetBookStores()
        {
            return SharedtenantContext.BookStores.Where(b=>b.EndSubscriptionDate>=System.DateTime.Now);
        }
        public IQueryable<string> GetDomins()
        {
            return SharedtenantContext.BookStores.Select(x => x.Domain);
        }
        public IQueryable<BookStores> GetRelatedBookStores( string SearchValue)
        {
          
            IQueryable<BookStores> RelatedBookStores = SharedtenantContext.BookStores.Where(b => b.EndSubscriptionDate >= System.DateTime.Now).FullTextSearchQuery(SearchValue);
          
            if(!RelatedBookStores.Any())
            {
                return RelatedBookStores= Enumerable.Empty<BookStores>().AsQueryable();
            }
            return RelatedBookStores;
        }
        public void AddBookStore(BookStores bookStores)
        {
            SharedtenantContext.BookStores.Add(bookStores);
            SharedtenantContext.SaveChanges();
        }
       
    }
}
