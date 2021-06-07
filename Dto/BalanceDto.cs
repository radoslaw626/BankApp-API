using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Dto
{
    public class BalanceDto
    {
        public long Id { get; set; }
        public string Login { get; set; }
        public decimal Balance { get; set; }
    }
}
