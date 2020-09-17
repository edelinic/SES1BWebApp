using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public static partial class OrderItemsRepositoryExtension
    {
        public static Orderitems WithOrderItemsId(this IQueryable<Orderitems> orderitems, int OrderId)
        {
            return orderitems.SingleOrDefault(p => p.OrderId == OrderId);
        }
    }
}
