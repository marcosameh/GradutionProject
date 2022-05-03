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
                options.Conventions.AddPageRoute("/customer/books", "/{UrlName}/books");
                options.Conventions.AddPageRoute("/Books/Delete", "/books/delete/{Id}");
                options.Conventions.AddPageRoute("/author/Delete", "/author/delete/{Id}");
                options.Conventions.AddPageRoute("/customer/book-details", "/{UrlName}/book-details/{Id}");
                options.Conventions.AddPageRoute("/customer/author-details", "/{UrlName}/author-details/{Id}");
                options.Conventions.AddPageRoute("/customer/cart", "/{UrlName}/cart/{Id?}");

                






            });


            return services;
        }


    }
}
