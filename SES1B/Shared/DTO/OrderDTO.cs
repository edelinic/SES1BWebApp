using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Shared.DTO
{
    public class OrderDTO
    {
        public int OrderId { get; set; }
        public int BookingId { get; set; }

        public List<BookingDTO> Booking { get; set; }
    }
}
