using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public static partial class BookingRepositoryExtension
    {
        public static Booking WithBookingId(this IQueryable<Booking> bookings, int bookingId)
        {
            return bookings.SingleOrDefault(p => p.BookingId == bookingId);
        }
    }
}
