using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BankAPI.Model
{
    public class Transfer
    {
        public long Id { get; set; }
        public long SenderId { get; set; }
        public string SenderFullName { get; set; }
        public long ReceiverId { get; set; }
        public string ReceiverFullName { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public DateTime Date { get; set; }

    }
}
