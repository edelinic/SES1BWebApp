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
        IQueryable<Orderitems> GetOrderItems();
        void PostOrderItems(Orderitems orderitems);

    }


}
