using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Shared.DTO
{
    public class TableDTO
    {
        public int TableId { get; set; }
        public int Seating { get; set; }
        public byte IsReserved { get; set; }
        public int? BookingId { get; set; }

        public List<BookingDTO> Booking { get; set; }
    }
}
