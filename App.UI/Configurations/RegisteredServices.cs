
using App.Core.Models;
using App.Customer.ViewManger;
using App.Librarian.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SharedTenant.Manager;
using SharedTenant.Models;

namespace App.UI.Configurations
{
    public static class RegisteredServices
    {


        public static IServiceCollection AddRegisteredServices(this IServiceCollection services)
        {


           

            /*use this pattern to register your serivces
             * services.AddScoped(s => new NameOfManager(s.GetService<NameOfContext>())
             */
            services.AddScoped<AuthorManager>();
            services.AddScoped<OffersView>();
            services.AddScoped<LibrarianView>();
            services.AddScoped<SectionView>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            return services;

        }

    }
}
