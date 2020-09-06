using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace SES1B.Models
{
    public class NewAccount : IdentityUser 

    {
        //These required fields basically mean that the user HAS to enter in this data before they sign up. 
       [Required, MaxLength(180), Display(Name = "First Name") ]
        public String firstname { get; set;}
        [Required, MinLength(6), MaxLength(15), DataType(DataType.Custom), Display(Name = "Last Name")]
        public String lastname { get; set; }
        [Required, MinLength(6), MaxLength(15), DataType(DataType.Custom), Display(Name = "Username")]
        public String username { get; set;}
        [Required, MinLength(6), MaxLength(15), DataType(DataType.Password), Display(Name = "Enter Password")]
        public int Password { get; set; }
       [Required, MinLength(6), MaxLength(15), DataType(DataType.Password), Display(Name = "Confirm Password")]
        public int confirmPassword { get; set; }
        [Required, EmailAddress, MinLength(6), MaxLength(15), DataType(DataType.Password), Display(Name = "EmailAddress")]
        public string EmailAddress { get; set; }
        [Required, Phone, MinLength(8), DataType(DataType.Password), MaxLengthAttribute(15), Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }
        //Does userID get a seperate required field or is one automatically generated for the user? 
        public int userID { get; set; }
        [Required, MinLength(6), MaxLength(8), DataType(DataType.Custom), Display(Name = "Date of Birth")]
        public int DOB { get; set; }

        public NewAccount(String firstname, String lastname, int password, string emailaddress, string phoneNumber, int userID, string username, int dob)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.Password = password;
            this.EmailAddress = emailaddress;
            this.phoneNumber = phoneNumber;
            this.DOB = dob; 
            this.userID = userID;
            this.username = username;
        }

        
    }
}
