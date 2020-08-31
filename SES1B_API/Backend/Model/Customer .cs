namespace Backend.Model
{
    public class Customer 
    {
        string First_Name; 
        string Last_Name;
        string email; 
        double DOB;


    public Customer(string firstname, string lastname, string email, double dob) {
        this.First_Name = firstname;
        this.Last_Name = lastname;
        this.DOB = dob;
        this.email = email;
    }
            public String getFirstName() {
            return First_Name;
        }
            public void setFirstName(string firstname) {
                First_Name = firstname;
            }
    
    }
        
    }
}
}