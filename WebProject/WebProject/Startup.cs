using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;


namespace WebProject
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
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser, AppRole>().AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews();
           
            services.AddMvc();
            

            //Authorize
            services.AddMvc(config =>
            {
                var policy = new AuthorizationPolicyBuilder()
                                    .RequireAuthenticatedUser()
                                    .Build();
                config.Filters.Add(new AuthorizeFilter(policy));
            });
            

            services.AddAuthentication(
                CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(x => 
                {
                    x.LoginPath = "/Login/Index";
                   
                });
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
                app.UseExceptionHandler("/ErrorPage/Error1");
            }

            app.UseStatusCodePagesWithReExecute("/ErrorPage/Error1", "?code = {0}");

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "article",
                    pattern: "{category}/{article}-{id}",
                    defaults: new { controller = "Blog", action = "BlogReadAll" });

                endpoints.MapControllerRoute(
                    name: "areas",
                    pattern: "{area:exists}/{controller=Blog}/{action=Index}/{id?}");

                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Blog}/{action=Index}/{id?}",
                    defaults: new { controller = "Blog", action = "Index" });

                //endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
