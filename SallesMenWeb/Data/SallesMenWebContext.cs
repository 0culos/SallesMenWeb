using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SallesMenWeb.Models;

namespace SallesMenWeb.Data
{
    public class SallesMenWebContext : DbContext
    {
        public SallesMenWebContext (DbContextOptions<SallesMenWebContext> options)
            : base(options)
        {
        }

        public DbSet<SallesMenWeb.Models.Department> Department { get; set; }
    }
}
