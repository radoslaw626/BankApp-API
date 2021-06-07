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
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly BankContext _context;
        private UserService userService;

        public RegisterController(BankContext context)
        {
            _context = context;
            userService = new UserService(_context);
        }
        [HttpPost]
        public void Register(RegisterDto register)
        { 
            userService.Register(register);
        }
    }
}
