using System;
using System.ComponentModel.DataAnnotations;

namespace SES1B.Models
{
    public class AuthenticateModel
    {

        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }

        public AuthenticateModel()
        {
            
        }
    }
}
