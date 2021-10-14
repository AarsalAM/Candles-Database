using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Candles_Database.Models;

namespace Candles_Database.Data
{
    public class Candles_DatabaseContext : DbContext
    {
        public Candles_DatabaseContext (DbContextOptions<Candles_DatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Candles_Database.Models.Candles> Candles { get; set; }
    }
}
