using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPI.Dto;
using BankAPI.Model;
using BankAPI.Services;

namespace BankAPI.Controllers
{
    [Route("api/user")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly BankContext _context;
        private UserService userService;

        public LoginController(BankContext context)
        {
            _context = context;
            userService = new UserService(_context);
        }

        [HttpGet("exists")]
        public UsernameDto Exist()
        {
            return userService.UserExists();
        }

        [HttpPost("login")]
        public UserDto Login(LoginDto login)
        {
            return userService.Login(login);
        }


    }
}
