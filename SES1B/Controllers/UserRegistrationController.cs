using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using SES1B.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SES1B.Controllers
{
    [Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly RegistrationController _context;
        public RegistrationController(RegistrationController context)
        {
            _context = context;
        }

        // GET: api/User
        protected void Register_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection();
            conn.ConnectionString = "server=restaurantdb.cvz3e6ne8iwm.ap-southeast-2.rds.amazonaws.com;database=Restaurant;uid=root;pwd=12345678";
            conn.Open();
            //source: https://ozanecare.com/how-to-create-registration-form-in-asp-net-with-mysql/?fbclid=IwAR0Zdhsy4fbRSFcs0AbP47K7rWXnGg-cU423gVLi_.AOZXMA6WwFdlh3xSOoM
            //Please check that this code works and fucking pray 
            MySqlCommand cmd = new MySqlCommand("Insert into TabUser" + "UserID, First Name, Last Name, Email, Password, DOB, Phone Number, Loyalty Member) " + "values @FirstName, @LastName, @Email, @Password, @DOB, @PhoneNumber, @Loyalty Member", conn);

            cmd.Parameters.AddWithValue("@FirstName", m_fname.Text); //ID tags need to be created for the links to happen. 
            cmd.Parameters.AddWithValue("@LastName", m_lname.Text);
            cmd.Parameters.AddWithValue("@Email", m_email.Text);
            cmd.Parameters.AddWithValue("@PhoneNumber", m_phone.Text); //Please troubleshoot this. 
            cmd.Parameters.AddWithValue("@DOB", m_date.Text);

            cmd.ExecuteNonQuery();
            m_fname.Text = "";
            m_lname.Text = "";
            m_email.Text = "";
            m_phone.Text = "";
            m_date.Text = "";
        }



        // GET: api/User
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
