using System;
using SES1B_API;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
//using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;



namespace SES1B_API.Controllers
{
      
        public class Register_User_Functionality: IdentityUser
    {
        String firstName;
        String lastName; 

        [PersonalData]
        public String getfirstName() {
            return firstName;
        }

        [PersonalData]
        public String getLastName() {}


        public static System.Web.Security.MembershipUser CreateUser ()
            
        }


    }

}