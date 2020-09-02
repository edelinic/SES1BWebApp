using System;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity;

namespace SES1B.Models
{
    public class UserAccount  //IdentityUser
    {
        [PersonalData]
        public int Id { get; set; } //setting and getting the account ID
        [PersonalData]
        public string Username { get; set; }
        [PersonalData]
        public string Password { get; set; }
        
        [PersonalData]
        public string FullName { get; set; }

    }


    //public Account()
      //  {
            //something here about data annotations and a key
        //}
}
