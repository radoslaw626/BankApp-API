using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using BankAPI.Dto;
using BankAPI.Model;
using BankAPI.Services;

namespace BankAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TransferController : ControllerBase
    {
        private readonly BankContext _context;

        public TransferController(BankContext context)
        {
            _context = context;
            transferService = new TransferService(_context);
        }

        private TransferService transferService;
        
        [HttpGet("{id}")]
        public TransferDetailsDto Get(long id)
        {
            return transferService.Get(id);
        }

        [HttpPost]
        public void NewTransfer([FromBody] NewTransferDto transfer)
        {
             transferService.Create(transfer);
        }

        [HttpGet]
        public IEnumerable<TransferItemDto> GetAll()
        {
            return transferService.GetAll();
        }


    }
}
