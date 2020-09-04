using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SES1B.Models
{
    public class NewAccount : IdentityUser 

    //Gonna have to modify the model so that it takes in works for identity. Please add these in later.



    { 
  
       [Required, EmailAddress, MaxLength(180), Display(Name = "Emaill Address") ]
        public String firstname { get; set;}
        public String lastname { get; set; }
        public int Password { get; set; }
       [Required, EmailAddress, MinLength(6), MaxLength(15), DataType(DataType.Password), Display(Name = "Confirm Password")]
        public int confirmPassword { get; set; }
        [Required, EmailAddress, MinLength(6), MaxLength(15), DataType(DataType.Password), Display(Name = "Password")]
        public string EmailAddress { get; set; }
        [Required, Phone, MinLength(8), MaxLengthAttribute(15), Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }


        //[Compare("Password", ErrorMessage = "The password does not match the confirmation password")]
        public NewAccount(String firstname, String lastname, int password, string emailaddress, string phoneNumber)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.Password = password;
            this.EmailAddress = emailaddress;
            this.phoneNumber = phoneNumber; 

        }

        
    }
}
