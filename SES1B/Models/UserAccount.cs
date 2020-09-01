using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SES1B.Models
{
    public class UserAccount
    {
        [Table("Account")] //Add the name of the table in the database. The error must be something to do with the database methinks


        [Key] //Methinks that there's an issue with the SQL components not being set up. 
        public int Id { get; set; } //setting and getting the account ID
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }

        
    }


    //public Account()
      //  {
            //something here about data annotations and a key
        //}
}
