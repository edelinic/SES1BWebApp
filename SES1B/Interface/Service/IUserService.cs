using SES1B.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Interface.Service
{
    public interface IUserService
    {
        UserDTO Login(UserDTO userDto);
        UserDTO Register(UserDTO userDto);
    }
}
