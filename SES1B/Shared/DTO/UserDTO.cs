using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Shared.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string LoyaltyMemberNumber { get; set; }
        public string Token { get; set; }
        public List<BookingDTO> Booking { get; set; }
        public bool IsLoginSuccess { get; set; }
    }
}
