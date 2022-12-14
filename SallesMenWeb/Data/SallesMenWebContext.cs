using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesMenWeb.Models;

namespace SallesMenWeb.Models
{
    public class SallesMenWebContext : DbContext
    {
        public SallesMenWebContext (DbContextOptions<SallesMenWebContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Department { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<SalesRecord> SalesRecord { get; set; }
    }
}
