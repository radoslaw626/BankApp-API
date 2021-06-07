using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;

namespace BankAPI.Dto
{
    public class UserDto
    {
       public string Login { get; set; }
       public string Token { get; set; }
    }
}
