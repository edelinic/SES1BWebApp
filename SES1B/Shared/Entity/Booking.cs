using System;
using System.Collections.Generic;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class Booking
    {
        public Booking()
        {
            Order = new HashSet<Order>();
            Table = new HashSet<Table>();
        }

        public int BookingId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPeople { get; set; }
        public byte OrderPlaced { get; set; }
        public string SpecialRequests { get; set; }
        public int CustomerId { get; set; }

        public virtual User Customer { get; set; }
        public virtual ICollection<Order> Order { get; set; }
        public virtual ICollection<Table> Table { get; set; }
    }
}
