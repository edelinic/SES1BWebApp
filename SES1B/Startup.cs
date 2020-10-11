using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blessre.Shared.Helper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SES1B.Interface.Service;
using SES1B.Models;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using SES1BBackendAPI.Service;

namespace SES1B
{
    public class Startup
    {
        readonly string restaurantSpecificOrigins = "_restaurantSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy(name: restaurantSpecificOrigins,
                                  builder =>
                                  {
                                      builder.WithOrigins("http://localhost:4200")
                                                           .AllowAnyHeader()
                                                           .AllowAnyMethod(); ;
                                  });
            });

            services.AddControllers();
            services.AddDbContext<RestaurantContext>();
            
            // THIS IS THE DEPENDANCY INJECTION //
            // COPY THIS // service.AddTransient<I#YOUR SERVICE NAME#, #YOUR SERVICE NAME#>(); //
            // Automatically injected during runtime and the config of this will be here //
            services.AddTransient<IRepository, Repository>();
            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<IOrderService, OrderService>();
            services.AddTransient<IOrderItemsService, OrderItemsService>();
            services.AddTransient<ITableService, TableService>();


            RestaurantConfiguration.Instance.Configuration = Configuration;
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseCors(restaurantSpecificOrigins);
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
