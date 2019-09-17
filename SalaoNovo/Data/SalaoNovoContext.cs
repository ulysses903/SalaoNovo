using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalaoNovo.Models
{
    public class SalaoNovoContext : DbContext
    {
        public SalaoNovoContext (DbContextOptions<SalaoNovoContext> options)
            : base(options)
        {
        }

        public DbSet<SalaoNovo.Models.Cliente> Cliente { get; set; }
    }
}
