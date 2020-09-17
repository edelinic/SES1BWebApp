using System;
using System.Collections.Generic;

namespace SES1BBackendAPI.Domain.Entity
{
    public partial class User
    {
        public User()
        {
            Booking = new HashSet<Booking>();
        }

        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Dob { get; set; }
        public string PhoneNumber { get; set; }
        public string LoyaltyMemberNumber { get; set; }

        public virtual ICollection<Booking> Booking { get; set; }
    }
}
