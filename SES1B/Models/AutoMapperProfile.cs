using System;
using AutoMapper;

namespace SES1B.Models
{
    public class AutoMapperProfile :Profile
    {
        //Automapper enables us to automatically map one type of class to another. Here, it's being used to map user entiteis and a few
        //model types together - 5/09/2020 CMM
        //You need to install the AutoMapper packages (AutoMapper and AutoMapper.Extensions.Microsoft.DependencyInjection (8.0.1))

        public AutoMapperProfile()
        {
            CreateMap<User, UserModel>();
            CreateMap<NewAccount, User>();
        }

        
    }
}
