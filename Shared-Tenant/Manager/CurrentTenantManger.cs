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

        public CurrentTenantManager(IHttpContextAccessor Accessor, SharedtenantContext sharedtenantContext)
        {
            this.Accessor = Accessor;
            this.SharedtenantContext = sharedtenantContext;
        }
        public BookStores GetCurrentBookStore()
        {
            //{https://localhost:44381/customer
            string[] url = UrlOperation(Accessor.HttpContext.Request.GetEncodedUrl());
            //url[3] = customer
            var result = SharedtenantContext.BookStores.Where(Librarian => Librarian.UrlName == url[3]).FirstOrDefault();
            if (result != null)
                return result;

            //url[2]=localhost:44381
            string DominName = url[2];
            return SharedtenantContext.BookStores.Where(x => x.Domain == DominName).FirstOrDefault();


        }
        public string[] UrlOperation(string url)
        {
            string[] URL = url.Split('/');
            return URL;

        }
        public IQueryable<BookStores> GetBookStores()
        {
            return SharedtenantContext.BookStores;
        }

    }
}
