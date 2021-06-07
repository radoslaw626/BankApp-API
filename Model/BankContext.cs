using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BankAPI.Model
{
    public class BankContext: DbContext
    {
        public BankContext(DbContextOptions<BankContext> options) : base(options)
        {


        }

        public DbSet<User> Users { get; set; }
        public DbSet<Transfer>Transfers { get; set; }
    }


}
