using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DotNetCorePortfolio.Models;

namespace DotNetCorePortfolio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<DotNetCorePortfolio.Models.Experience> Experience { get; set; }
        public DbSet<DotNetCorePortfolio.Models.Skill> Skill { get; set; }
        public DbSet<DotNetCorePortfolio.Models.Project> Project { get; set; }
        public DbSet<DotNetCorePortfolio.Models.Message> Message { get; set; }
    }
}
