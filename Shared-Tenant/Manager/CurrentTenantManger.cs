using SharedTenant.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
using System.Linq;

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
            var CurrentDomin = Accessor.HttpContext.Request.Host.Value;
            foreach (var domin in GetDomins())
            {
                if (domin == CurrentDomin && CurrentDomin != "localhost:44381")
                {
                    return SharedtenantContext.BookStores.Where(x => x.Domain == CurrentDomin).FirstOrDefault();
                }

            }
            return SharedtenantContext.BookStores.Where(x => x.UrlName == UrlName).FirstOrDefault();


        }
    
        public IQueryable<BookStores> GetBookStores()
        {
            return SharedtenantContext.BookStores;
        }
        public IQueryable<string> GetDomins()
        {
            return SharedtenantContext.BookStores.Select(x => x.Domain);
        }
    }
}
