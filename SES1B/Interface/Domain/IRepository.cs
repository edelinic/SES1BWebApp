using SES1BBackendAPI.Domain.Entity;
using System.Collections.Generic;
using System.Linq;

namespace SES1BBackendAPI.Interface.Domain
{
    public interface IRepository
    {
        IQueryable<User> GetUser();
        void PostUser(User user);
        void PostBooking(Booking booking);
        IQueryable<Order> GetOrders();
        void PostOrder(Order order);
        void RemoveOrder(Order order);
        IQueryable<Orderitems> GetOrderItems();
        void PostOrderItems(Orderitems orderitems);
        void RemoveOrderItems(Orderitems orderItems);
        IQueryable<Table> GetTables();
        void PostTable(Table table);
        void RemoveTable(Table table);
    }


}
