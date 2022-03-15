using Microsoft.Extensions.DependencyInjection;

namespace App.UI.Configurations
{
    public static class Routes
    {
        public static IServiceCollection AddCustomizedRoutes(this IServiceCollection services)
        {
            services.AddRazorPages(options =>
            {



              
                options.Conventions.AddPageRoute("/customer/Index", "/{UrlName}/Index");
                options.Conventions.AddPageRoute("/customer/Authors", "/{UrlName}/Authors");
                options.Conventions.AddPageRoute("/customer/section", "/{UrlName}/section");








            });


            return services;
        }


    }
}
