using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Task1.Data
{
    public class WellDocDbContext : IdentityDbContext
    {
        public WellDocDbContext(DbContextOptions contextOptions) : base(contextOptions)
        {

        }
        public DbSet<WellDocUser> WellDocUser { get; set; }
    }
}
