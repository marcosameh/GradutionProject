using App.Customer.CustomerAutoMapper;
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
using SharedTenant.Models;
using System.Security.Claims;
using X.Paymob.CashIn;

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


            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {

                options.Password.RequireUppercase = false;
                options.Password.RequireNonAlphanumeric = false;
                options.ClaimsIdentity.UserIdClaimType = "UserID";
            }).AddEntityFrameworkStores<SharedtenantContext>().AddDefaultUI().AddDefaultTokenProviders();
            
          


            services.AddAutoMapper(x => x.AddProfile(new DominProfile()));
            services.AddAutoMapper(x => x.AddProfile(new CustomerDomainProfile()));



            services.AddRegisteredServices();
            services.AddPaymobCashIn(config =>
            {
                config.ApiKey = Configuration.GetValue<string>("PaymobConfiguration:ApiKey");
                config.Hmac = Configuration.GetValue<string>("PaymobConfiguration:Hmac");

                //config.IframeBaseUrl
            });
            services.AddCustomizedRoutes();




            //services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.ConfigureApplicationCookie(options => options.LoginPath = "/Account/Login");


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
            app.UseRouting();
            app.UseStaticFiles();


            app.UseAuthentication();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

        }
    }
}
