using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace secureAPI.Data
{
    public class WireGuardContext : DbContext
    {
        public WireGuardContext(DbContextOptions<WireGuardContext> options) : base(options) { }

        public DbSet<WireGuardInfo> wireGuardInfo { get; set; }
    }
}
