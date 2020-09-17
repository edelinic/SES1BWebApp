using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public static partial class OrderRepositoryExtension
    {
        public static Order WithOrderId(this IQueryable<Order> orders, int OrderId)
        {
            return orders.SingleOrDefault(p => p.OrderId == OrderId);
        }
    }
}
