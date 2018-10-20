using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SanMarinoClassicWebsite.Auth;
using SanMarinoClassicWebsite.Models;
using System.Globalization;

namespace SanMarinoClassicWebsite
{
    public class Startup
    {
        private IConfigurationRoot _configurationRoot;

        public Startup(IHostingEnvironment hostingEnvironment)
        {
            CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("fil-PH");

            _configurationRoot = new ConfigurationBuilder()
                   .SetBasePath(hostingEnvironment.ContentRootPath)
                   .AddJsonFile("appsettings.json")
                   .Build(); 

        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options =>
                                    options.UseSqlServer(_configurationRoot.GetConnectionString("DefaultConnection")));
            services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {
                options.Password.RequiredLength = 8;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.User.RequireUniqueEmail = true;
                
            }
)
            .AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders(); 
            
            services.AddTransient<IEquipmentTypeRepository, EquipmentTypeRepository>();
            services.AddTransient<IEquipmentRepository, EquipmentRepository>();
            //services.AddTransient<IPieRepository, PieRepository>();
            //services.AddTransient<ICategoryRepository, CategoryRepository>();
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            //services.AddScoped(sp => ShoppingCart.GetCart(sp));
            services.AddScoped(rp => ReservedItem.GetReserved(rp));
            services.AddTransient<IReservationRepository, ReservationRepository>();
            //services.AddTransient<IStatusRepository, StatusRepository>();
            services.AddTransient<IRentalRepository, RentalRepository>();

            services.AddMvc();

            services.AddAuthentication()
               .AddGoogle(options =>
               {
                   options.ClientId = "954504023788-69a9a2fj2u64qhgv6jccnpkk3bi7ejk4.apps.googleusercontent.com";
                   options.ClientSecret = "6NK9lMSovIuwVa-uuWS5J1R5";
               });



            //services.AddSingleton(factory => new PayPalHttpClientFactory(
            //    Configuration["PayPal:ClientId"],
            //    Configuration["PayPal:ClientSecret"],
            //    Convert.ToBoolean(Configuration["PayPal:IsLive"]))); // Is Live Environment?

            services.AddAuthorization(options =>
                {
                    options.AddPolicy("AdministratorOnly", policy => policy.RequireRole("Administrator"));
                });
            services.AddMemoryCache();
            services.AddSession();
        }

       
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/AppException");
            }

            app.UseStaticFiles();
            app.UseSession();
            app.UseCookiePolicy();
            app.UseAuthentication();

            loggerFactory.AddConsole(LogLevel.Debug);
            loggerFactory.AddDebug(LogLevel.Debug);

         
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                name: "areaRoute",
                template: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

                routes.MapRoute(
                    name: "categoryfilter",
                    template:"Pie/{action}/{category?}",
                    defaults: new {Controller ="Pie", action ="List"});

                routes.MapRoute(
                    name: "typefilter",
                    template: "Equipment/{action}/{type?}",
                    defaults: new { Controller = "Equipment", action = "List" });

                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });



        }
    }

}
