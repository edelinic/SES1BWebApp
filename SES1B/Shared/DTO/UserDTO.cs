using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Shared.DTO
{
    public class UserDTO
    {
        public UserDTO() {
            Messages = new List<string>();

        }
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string LoyaltyMemberNumber { get; set; }
        public string Token { get; set; }
        public List<BookingDTO> Booking { get; set; }

        public List<string> Messages { get; set; }
        public bool IsSuccess { get; set; }
    }
}
