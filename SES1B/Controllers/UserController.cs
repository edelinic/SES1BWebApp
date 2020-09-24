
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;

namespace SES1B.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        [HttpPost("login")]
        public ActionResult<UserDTO> Login([FromBody] UserDTO userDto)
        {
            return _userService.Login(userDto);
        }

        [HttpPost("/register")]
        public ActionResult<UserDTO> Register([FromForm] UserDTO userDto)
        {
            return _userService.Register(userDto);
        }
    }
}