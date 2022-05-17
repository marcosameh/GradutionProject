using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
namespace App.UI.Configurations
{
    public class Global
    {

        public static string UrlName;
        public static string ReturnUrl;

    }
    public class GlobalManger
    {
        private readonly IHttpContextAccessor Accessor;

        public GlobalManger(IHttpContextAccessor Accessor)
        {
            this.Accessor = Accessor;
        }
        public string SetGlobalVariable()
        {

            //removes any handler from the url
            string[] url= Accessor.HttpContext.Request.GetEncodedUrl().Split("?handler");
            Global.ReturnUrl = url[0];
            

                string[] URLSplit = Global.ReturnUrl.Split("/");
                Global.UrlName = URLSplit[3];


          
            return Global.UrlName;
        }
    }
    

  
}
