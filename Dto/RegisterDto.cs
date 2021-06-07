using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace BankAPI.Dto
{
    public class RegisterDto
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
