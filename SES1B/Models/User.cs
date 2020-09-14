using System;
using System.ComponentModel.DataAnnotations;

namespace SES1B.Models

{
    public partial class User
    {
        [Key]
        public int userId { get; set; }

        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public double DOB { get; set; }
        public int phoneNumber { get; set; }
        public int loyaltyNumber { get; set; }

        public User()
        {

        }
    }
}