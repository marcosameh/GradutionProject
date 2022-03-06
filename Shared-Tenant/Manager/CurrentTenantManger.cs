using SharedTenant.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System;

namespace SharedTenant.Manager
{
    public  class CurrentTenantManager
    {



        private readonly IHttpContextAccessor Accessor;
        private readonly SharedtenantContext SharedtenantContext;

        public CurrentTenantManager(IHttpContextAccessor Accessor,SharedtenantContext sharedtenantContext)
        {
            this.Accessor = Accessor;
            this.SharedtenantContext = sharedtenantContext;
        }
        public BookStores GetCurrentBookStore()
        {
            string BaseConnection = Accessor.HttpContext.Request.QueryString.Value;
            if(BaseConnection.StartsWith("?library="))
            {
                string urlname = BaseConnection.Substring(9);
                var result = SharedtenantContext.BookStores.Where(Librarian => Librarian.Urlname == urlname).FirstOrDefault();
                if (result != null )
                    return result;
            }
            string DominName = Accessor.HttpContext.Request.Scheme + "://" + Accessor.HttpContext.Request.Host.Value;
            return SharedtenantContext.BookStores.Where(x => x.Domain == DominName).FirstOrDefault();
            

        }

    }
}
