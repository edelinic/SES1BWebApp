using System;
using System.Collections.Generic;

namespace SES1B.Models
{
    public partial class Table
    {
        public int TableId { get; set; }
        public int Seating { get; set; }
        public bool IsReserved { get; set; }
        public int BookingId { get; set; }
    }
}
