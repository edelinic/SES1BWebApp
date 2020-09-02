using System;

namespace SES1B.Models
{
    public class Account 
    {
        public int Id { get; set; }
        public String FirstName { get; set;}
        public String LastName { get; set; }
        public string Password { get; set; }
        public Account()
        {
        }
    }
}
