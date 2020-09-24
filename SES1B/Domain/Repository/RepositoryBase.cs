using Microsoft.EntityFrameworkCore;
using SES1BBackendAPI.Domain.Interface;
using System;
using System.Linq;

namespace SES1BBackendAPI.Domain.Repository
{
    public class RepositoryBase
    {
        private int TransactionLevel { get; set; }
        internal Entity.RestaurantContext _dataContext;

        // This will create the context when the repository is instantiated
        public RepositoryBase()
        {
            _dataContext = new Entity.RestaurantContext();
        }
    }
 
}
