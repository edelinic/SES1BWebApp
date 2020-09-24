using blessre.Shared.Helper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class RestaurantContext
    {
        IConfiguration _configuration;

        public RestaurantContext()
        {
            _configuration = RestaurantConfiguration.Instance.Configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(_configuration["ConnectionStrings:UserAccountContext"]);
            }
        }

    }
}
