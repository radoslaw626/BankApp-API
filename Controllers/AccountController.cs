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
    [Route("[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly BankContext _context;
        private UserService userService;

        public AccountController(BankContext context)
        {
            _context = context;
            userService = new UserService(_context);
        }
        [HttpGet("balance")]
        public BalanceDto Balance()
        {
            return userService.Balance();
        }

    }
}
