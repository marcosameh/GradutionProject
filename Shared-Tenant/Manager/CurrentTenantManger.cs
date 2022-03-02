using SharedTenant.Models;
using Microsoft.AspNetCore.Http;
using System.Linq;

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
            string DominName = Accessor.HttpContext.Request.Scheme + "://" + Accessor.HttpContext.Request.Host.Value;
            return SharedtenantContext.BookStores.Where(x => x.Domain == DominName).FirstOrDefault();
            

        }

    }
}
