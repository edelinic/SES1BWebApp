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

        public static void CreateOrder(this IQueryable<Orderitems> orderitems, Orderitems OrderId) 
        {
            orderitems.Add(OrderId);
            orderitems.SaveChanges();
        }

        public static void EditOrder(this IQueryable<Orderitems> orderitems, Orderitems OrderId) 
        {
            orderitems.SaveChanges();
        }

        public static void DeleteOrder(this IQueryable<Orderitems> orderitems, Orderitems OrderId) 
        {
            orderitems.Remove(OrderId);
            orderitems.SaveChanges();
        }
    }
}
