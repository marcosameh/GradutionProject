using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;
namespace App.UI.Configurations
{
    public class Global
    {

        public static string UrlName;

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
            if(string.IsNullOrEmpty(Global.UrlName))
            {

                string URL = Accessor.HttpContext.Request.GetEncodedUrl();
                string[] URLSplit = URL.Split("/");
                Global.UrlName = URLSplit[3];
           

            }
            return Global.UrlName;
        }
    }
    

  
}
