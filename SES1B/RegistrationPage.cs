using System;
using MySql.Data.MySqlClient;
namespace SES1B
{
    public partial class RegistrationPage 

    {
        public RegistrationPage()
        {
        }

        protected void Register_Click(object sender, EventArgs e) {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=12345678";
            conn.Open();
            //source: https://ozanecare.com/how-to-create-registration-form-in-asp-net-with-mysql/?fbclid=IwAR0Zdhsy4fbRSFcs0AbP47K7rWXnGg-cU423gVLi_.AOZXMA6WwFdlh3xSOoM
//Please check that this code works and fucking pray 
            MySqlCommand cmd = new MySqlCommand("Insert into TabUser" + "UserID, First Name, Last Name, Email, Password, DOB, Phone Number, Loyalty Member) " + "values @FirstName, @LastName, @Email, @Password, @DOB, @PhoneNumber, @Loyalty Member", conn);

            cmd.Parameters.AddWithValue("@FirstName", m_fname.Text); //These m_fname are the links to the angular files that Jason created with HTML & CSS
            cmd.Parameters.AddWithValue("@LastName", m_lname.Text);
            cmd.Parameters.AddWithValue("@Email", m_email.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", m_phone.Text);
            cmd.Parameters.AddWithValue("@DOB", m_date.Text);

            cmd.ExecuteNonQuery();
            m_fname.Text = "";
            m_lname.Text = "";
            m_email.Text = "";
            m_phone.Text = "";
            m_date.Text = "";
        }
    }
}
