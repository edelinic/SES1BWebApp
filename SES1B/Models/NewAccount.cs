using System;

namespace SES1B.Models
{
    public class NewAccount

        //Gonna have to modify the model so that it takes in works for identity. Please add these in later.
  


    {
        public int Id { get; set; }
        public String firstname { get; set;}
        public String lastname { get; set; }
        public int Password { get; set; }


        public NewAccount(String firstname, String lastname, int password, int id)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.Password = password;
            this.Id = id; 
        }

        
    }
}
