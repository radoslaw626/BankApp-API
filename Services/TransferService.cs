using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BankAPI.Dto;
using BankAPI.Model;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;

namespace BankAPI.Services
{
    public class TransferService
    {
        private readonly BankContext _context;

        public TransferService(BankContext context)
        {
            _context = context;
        }
        public void Create(NewTransferDto transfer)
        {
            var newTransfer = new Transfer
            {
                Amount = transfer.amount,
                Currency = transfer.currency,
                Date = DateTime.Now,
                Id = transfer.Id,
                ReceiverFullName = transfer.receiver_full_name,
                ReceiverId = transfer.receiver_id,
                SenderFullName = transfer.sender_full_name,
                SenderId = transfer.sender_id
            };
                
            
            _context.Transfers.Add(newTransfer);
            _context.SaveChanges();
        }

        public IEnumerable<TransferItemDto> GetAll()
        {
            return _context.Transfers.ToList().Select(x => new TransferItemDto
            {
                Id = x.Id,
                amount = x.Amount,
                currency = x.Currency,
                date = x.Date.ToString("dd-MM-yyyy"),
                receiver_full_name = x.ReceiverFullName,
                receiver_id = x.ReceiverId,
                sender_full_name = x.SenderFullName,
                sender_id = x.SenderId
            });
        }

        public TransferDetailsDto Get(long id)
        {
            var transfer = _context.Transfers.Single(x => x.Id == id);

            return new TransferDetailsDto
            {
                Id = transfer.Id,
                amount = transfer.Amount,
                currency = transfer.Currency,
                date = transfer.Date.ToString("dd-MM-yyyy"),
                receiver_full_name = transfer.ReceiverFullName,
                receiver_id = transfer.ReceiverId,
                sender_full_name = transfer.SenderFullName,
                sender_id = transfer.SenderId
            };
        }

    }
}
