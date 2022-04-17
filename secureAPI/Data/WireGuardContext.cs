using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using secureAPI.Models;

namespace secureAPI.Data
{
    public class WireGuardContext : DbContext
    {
        public WireGuardContext(DbContextOptions<WireGuardContext> options) : base(options) { }

        public DbSet<WireGuardInfo> wireGuardInfo { get; set; }
        public DbSet<UserInfo> userInfo { get; set; }
        public DbSet<UserModelInfo> userModelInfo { get; set; }
       public DbSet<Comments> comments { get; set; }
    }
}
