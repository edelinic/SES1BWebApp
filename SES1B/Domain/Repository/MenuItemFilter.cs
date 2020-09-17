using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public static partial class BookingRepositoryExtension
    {
        public static Menuitems WithMenuItemId(this IQueryable<Menuitems> menuitems, int Id)
        {
            return menuitems.SingleOrDefault(p => p.Id == Id);
        }
    }
}
