using Microsoft.Extensions.DependencyInjection;

namespace App.UI.Configurations
{
    public static class Routes
    {
        public static IServiceCollection AddCustomizedRoutes(this IServiceCollection services)
        {
            services.AddRazorPages(options =>
            {



                //options.Conventions.AddPageRoute("/offer-details", "offer-details/{UrlName}");








            });


            return services;
        }


    }
}
