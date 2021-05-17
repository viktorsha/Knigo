using Knigo.Data;
using Knigo.Data.Interfaces;
using Knigo.Data.Repository;
using Knigo.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo
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
            services.AddDbContext<AppDBContentShakunVA>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddIdentity<IdentityUser, IdentityRole>(options => options.SignIn.RequireConfirmedAccount = false)
            //    .AddEntityFrameworkStores<AppDBContentShakunVA>();
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
               .AddEntityFrameworkStores<AppDBContentShakunVA>();
               

            services.AddRazorPages();
            services.AddTransient<IBooksShakunVA, BookRepositoryShakunVA>(); //соединяем между собой интерфейс и класс, который его реализует
            services.AddTransient<IBooksAuthorShakunVA, AuthorRepositoryShakunVA>();
            services.AddTransient<IBooksCategoryShakunVA, CategoryRepositoryShakunVA>();
            services.AddTransient<IBooksPublisherShakunVA, PublisherRepositoryShakunVA>();
            services.AddTransient<IBooksRankShakunVA, RankRepositoryShakunVA>();
            services.AddTransient<IBooksStatusShakunVA, StatusRepositoryShakunVA>();
            services.AddTransient<IEmailSender, EmailSender>();
            services.Configure<AuthMessageSenderOptions>(Configuration);
            services.AddMvc();
            services.AddMvc(options =>
            {               
                options.EnableEndpointRouting = false;
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();

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
                endpoints.MapControllerRoute(name: "Books", pattern: "{area:exists}/{controller=Books}/{action=List}");
                endpoints.MapControllerRoute(name: "Admin", pattern: "{area:exists}/{controller=Books}/{action=List}");

                endpoints.MapControllerRoute(name: "Categories", pattern: "{area:exists}/{controller=Category}/{action=List}");
                endpoints.MapControllerRoute(name: "Books", pattern: "{area:exists}/{controller=Books}/{action=List}/{id}");
                endpoints.MapControllerRoute(name: "Administration", pattern: "{area:exists}/{controller=Administration}/{action=CreateRole}");
                endpoints.MapControllerRoute(name: "default", pattern: "{area:exists}/{controller=Books}/{action=List}");
                //endpoints.MapControllers();
            });
            app.UseMvc(routes =>
            routes.MapRoute(name:"default", template: "{controller=Books}/{action=List}")
            );
            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDBContentShakunVA content = scope.ServiceProvider.GetRequiredService<AppDBContentShakunVA>(); //для добавления, удаления данных из бд

                DBObjects.Initial(content);
            }
        }
    }
}
