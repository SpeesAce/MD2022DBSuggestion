using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MD2022DBExperiment.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using Microsoft.AspNetCore.Authentication.Cookies;

namespace MD2022DBExperiment
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
            services.AddControllersWithViews();

            //Add DB Context with Identity
            var dbConn = Configuration.GetConnectionString("Default");
            services.AddDbContext<Context>(options => options.UseSqlServer(dbConn)).AddIdentity<IdentityUser, IdentityRole>(config =>
            {
                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 4;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
            }).AddEntityFrameworkStores<Context>()
            .AddDefaultTokenProviders();
            services.Configure<DataProtectionTokenProviderOptions>(o =>
                             o.TokenLifespan = TimeSpan.FromHours(1)); ;

            //Authentication
            services.AddAuthentication(
                    CookieAuthenticationDefaults.AuthenticationScheme
                ).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
                    options =>
                    {
                        options.LoginPath = "/Account/Login";
                    });


            // supplementary policies, to be used when we need a mix of roles
            services.AddAuthorization(options =>
            options.AddPolicy("admin", policy => policy.RequireRole("admin")));

            // groupleader
            services.AddAuthorization(options =>
            options.AddPolicy("groupleader", policy => policy.RequireRole("groupleader")));

            // standard users
            services.AddAuthorization(options =>
            options.AddPolicy("user", policy => policy.RequireRole("user")));

            //Speaker
            services.AddAuthorization(options =>
            options.AddPolicy("speaker", policy => policy.RequireRole("speaker")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                //Workaround to drop & build DB in EF 5 core, entities can be modified freely 
                app.UseDeveloperExceptionPage();
                using (var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope())
                {
                    var context = serviceScope.ServiceProvider.GetRequiredService<Context>();
                    context.Database.EnsureDeleted();
                    context.Database.EnsureCreated();
                    //seed()
                }
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
