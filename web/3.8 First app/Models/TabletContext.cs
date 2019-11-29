using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._8_First_app.Models
{
    public class TabletContext : DbContext
    {
        public DbSet<Tablet> Phones { get; set; }
        public DbSet<Order> Orders { get; set; }

        public TabletContext(DbContextOptions<TabletContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
