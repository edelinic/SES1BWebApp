using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blessre.Shared.Helper
{
    public sealed class RestaurantConfiguration
    {
        private static RestaurantConfiguration instance = null;
        private static readonly object padlock = new object();
        public IConfiguration Configuration { get; set; }
        RestaurantConfiguration()
        {
        }

        public static RestaurantConfiguration Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new RestaurantConfiguration();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
