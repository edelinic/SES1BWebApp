using System;
using System.Collections.Generic;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
