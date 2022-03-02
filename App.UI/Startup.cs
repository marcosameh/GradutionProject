using App.Core.Models;
using App.Librarian.AutoMapper;
using App.UI.Configurations;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SharedTenant.Domain;
using SharedTenant.Manager;
using SharedTenant.Models;

namespace App.UI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<SharedtenantContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("AppCore")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {

                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;

            })

                .AddEntityFrameworkStores<SharedtenantContext>().AddDefaultUI().AddDefaultTokenProviders();
            
            services.AddRegisteredServices();
            services.AddScoped<CurrentTenantManager>();
            services.AddScoped<BookStores>(serviceProvider => serviceProvider.GetService<CurrentTenantManager>().GetCurrentBookStore());
            services.AddScoped(serviceProvider => new KitabiContext(new DbContextOptionsBuilder<KitabiContext>()
                 .UseSqlServer(serviceProvider.GetService<BookStores>().ConnectionString,
                o => o.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery)).Options));

            services.AddAutoMapper(x => x.AddProfile(new DominProfile()));

            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");
            services.AddRazorPages();

            //URL in lower case
            services.Configure<RouteOptions>(option =>
            {
                option.LowercaseUrls = true;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });
        }
    }
}
