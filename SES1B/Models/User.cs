using System;
namespace SES1B.Models
{
    public class User
    {
        //Entity class stored in the database, this class has been modified to match the DB

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int DOB { get; set; }
        public string phoneNumber { get; set; }
        public int LoyaltyNumber { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public object Id { get; internal set; }
    }
}
