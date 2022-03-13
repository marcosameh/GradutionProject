
using App.Core.Models;
using App.Customer.ViewManger;
using App.Librarian.Managers;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SharedTenant.Manager;
using SharedTenant.Models;
namespace App.UI.Configurations
{
    public static class RegisteredServices
    {


        public static IServiceCollection AddRegisteredServices(this IServiceCollection services)
        {


            services 
            .AddScoped<BookManager>()
            .AddScoped<AuthorManager>()
            .AddScoped<OffersView>()
            .AddScoped<LibrarianView>()
            .AddScoped<SectionView>()
            .AddSingleton<IHttpContextAccessor, HttpContextAccessor>()
            .AddScoped(s => new CurrentTenantManager(s.GetService<IHttpContextAccessor>(), s.GetService<SharedtenantContext>(), Global.UrlName))
            .AddScoped<BookStores>(serviceProvider => serviceProvider.GetService<CurrentTenantManager>().GetCurrentBookStore())
            .AddScoped(serviceProvider => new KitabiContext(new DbContextOptionsBuilder<KitabiContext>()
                  .UseSqlServer(serviceProvider.GetService<BookStores>().ConnectionString,
                 o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)).Options));
            return services;

            /*use this pattern to register your serivces
             * services.AddScoped(s => new NameOfManager(s.GetService<NameOfContext>())
             */



        }

    }
}
