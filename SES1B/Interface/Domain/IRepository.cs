using SES1BBackendAPI.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace SES1BBackendAPI.Interface.Domain
{
    public interface IRepository
    {
        IQueryable<User> GetUser();
        IQueryable<Orderitems> GetOrderItems();
        // IQueryable<Orderitems> PostOrderItems();
    }
}
