using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Dto
{
    public class TransferDetailsDto
    {
        public long Id { get; set; }
        public long sender_id { get; set; }
        public string sender_full_name { get; set; }
        public long receiver_id { get; set; }
        public string receiver_full_name { get; set; }
        public decimal amount { get; set; }
        public string currency { get; set; }
        public string date { get; set; }
    }
}
