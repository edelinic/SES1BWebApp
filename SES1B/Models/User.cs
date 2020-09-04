using System;
namespace SES1B.Models
{
    public class User
    {
        //Entity class stored in the database

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public object Id { get; internal set; }
    }
}
