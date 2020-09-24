using System;
using System.Collections.Generic;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class Table
    {
        public int TableId { get; set; }
        public int Seating { get; set; }
        public byte IsReserved { get; set; }
        public int? BookingId { get; set; }

        public virtual Booking Booking { get; set; }
    }
}
