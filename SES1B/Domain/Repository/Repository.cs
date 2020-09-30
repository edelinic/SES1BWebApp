using SES1BBackendAPI.Domain.Entity;
using SES1BBackendAPI.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public class Repository : RepositoryBase, IRepository
    {
        public IQueryable<Booking> GetBooking()
        {
            return _dataContext.Booking;
        }

        public IQueryable<Menuitems> GetMenuItems()
        {
            return _dataContext. \Menuitems;
        }

        public IQueryable<Order> GetOrders()
        {
            return _dataContext.Order;
        }

        public IQueryable<Orderitems> GetOrderItems()
        {
            return _dataContext.Orderitems;
        }

        public IQueryable<Staff> GetStaff()
        {
            return _dataContext.Staff;
        }

        public IQueryable<Table> GetTables()
        {
            return _dataContext.Table;
        }

        public IQueryable<User> GetUser()
        {
            return _dataContext.User;
        }

    }
}
