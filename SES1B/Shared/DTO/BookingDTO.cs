using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Shared.DTO
{
    public class BookingDTO
    {
        public string Email { get; set; }
        public int BookingId { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int NumberOfPeople { get; set; }
        public byte OrderPlaced { get; set; }
        public string SpecialRequests { get; set; }
        public int CustomerId { get; set; }
        public List<OrderDTO> Order { get; set; }
        public List<TableDTO> Table { get; set; }
    }
}
