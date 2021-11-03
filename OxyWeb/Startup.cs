using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using OxyWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OxyWeb
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
            services.AddDbContext<ModelOxy>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DBConnection"))
            );

            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(60);
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseSession();

            IApplicationBuilder applicationBuilder = app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}");

                endpoints.MapControllerRoute(
                   name: "LogOut",
                   pattern: "LogOut",
                   defaults: new { controller = "Home", action = "LogOut" });

                endpoints.MapControllerRoute(
                    name: "vendor",
                    pattern: "vendor",
                    defaults: new { controller = "Tvendor", action = "Index" });

                endpoints.MapControllerRoute(
                    name: "AllVendor",
                    pattern: "AllVendor/{idRol}",
                    defaults: new { controller = "Tvendor", action = "GetVendor", idRol = "" });

                endpoints.MapControllerRoute(
                   name: "equipment",
                   pattern: "equipment",
                   defaults: new { controller = "Tequipment", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "field",
                   pattern: "field",
                   defaults: new { controller = "Tfield", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "well",
                   pattern: "well", 
                   defaults: new { controller = "Twell", action = "Index" });

                endpoints.MapControllerRoute(
                   name: "cleaning", 
                   pattern: "cleaning",
                   defaults: new { controller = "TCleaning", action = "Index" });

                endpoints.MapControllerRoute(
                  name: "events",
                  pattern: "events",
                  defaults: new { controller = "Tevents", action = "Index" });

                endpoints.MapControllerRoute(
                  name: "location", 
                  pattern: "location",
                  defaults: new { controller = "Tlocation", action = "Index" });

                endpoints.MapControllerRoute(
                  name: "user",
                  pattern: "user",
                  defaults: new { controller = "Tuser", action = "Index" });
            });
        }
    }
}
