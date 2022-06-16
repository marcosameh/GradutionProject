
using App.Core.Models;
using App.Customer.CartManager;
using App.Customer.RecommendedSystem;
using App.Customer.Views;
using App.Customer.WishlistManger;
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
            .AddScoped<BookCategoryListManager>()
            .AddScoped<AuthorManager>()
            .AddScoped<BookCategoryManager>()
            .AddScoped<GetBook>()
            .AddScoped<SectionView>()
            .AddScoped<RegisterFavouriteCategoryManger>()
            .AddScoped<RecommenedBooksManger>()
            .AddScoped<ExchangeBookManger>()
            .AddScoped<WishlistCRUD>()

            .AddSingleton<IHttpContextAccessor, HttpContextAccessor>()


            .AddScoped(s => new GlobalManger(s.GetService<IHttpContextAccessor>()))
            .AddScoped(s => new CurrentTenantManager(s.GetService<IHttpContextAccessor>(), s.GetService<SharedtenantContext>(), s.GetService<GlobalManger>().SetGlobalVariable()))
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
