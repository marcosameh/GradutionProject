using App.UI.Configurations;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;

namespace App.UI.Models
{

    public abstract class PageModelBase : PageModel
    {
        #region BookStoreName

        public string UrlName { get; set; }

        #endregion



        #region On Page Excution Handler and Methods
        public override async Task OnPageHandlerExecutionAsync(PageHandlerExecutingContext context, PageHandlerExecutionDelegate next)
        {
            SetUrlName(context);


            await next.Invoke();
        }

        private void SetUrlName(PageHandlerExecutingContext context)
        {
            string[] url = (HttpContext.Request.GetEncodedUrl().Split('/'));
            if (url.Length >= 3)
            {
                if(url[3]!="Index"){
                    Global.UrlName ="/"+ url[3];
                }
               
            }
            else
            {
                Global.UrlName = " ";
            }
            UrlName = Global.UrlName;
        }

        #endregion


    }
}
