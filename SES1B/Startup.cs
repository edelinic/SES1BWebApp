using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using SES1B.Models;
using Microsoft.EntityFrameworkCore;

namespace SES1B
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
            services.AddControllers();
           services.AddDbContext<RestaurantContext>(options =>
                           options.UseSqlServer(Configuration.GetConnectionString("restaurantdb.cvz3e6ne8iwm.ap - southeast - 2.rds.amazonaws.com")
           ));
            //Database area for users
            services.AddDbContext<NewAccountContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("restaurantdb.cvz3e6ne8iwm.ap - southeast - 2.rds.amazonaws.com")));
        

                


            //services.AddDbContext<DatabaseContext>(options =>
            //services.UseSqlServer(Configuration.GetConnectionString("UserAccountContext")));


            services.AddIdentity<IdentityUser, IdentityRole>(config => //AddIdentity registers the services for the Account
            {

                //Password settings 
                config.Password.RequiredLength = 6;
                config.Password.RequireDigit = true;
                config.Password.RequireNonAlphanumeric = true;
                config.Password.RequireUppercase = true;
               
                //user settings
                config.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";

            });
            //.AddEntityFrameworkStores<DatabaseContext>()
                //.AddDefaultTokenProviders();

            services.ConfigureApplicationCookie(config =>
            {
                config.Cookie.Name = "Identity.Cookie";
                config.LoginPath = "Home/Login"; //Double check this with the log in path. 

            });
                
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseAuthentication();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
