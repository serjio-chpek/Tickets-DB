using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21.Models
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<Point> Points { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Passanger> Passangers { get; set; }
        public ApplicationContext()
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=tickets.db");
            base.OnConfiguring(optionsBuilder);

        }
    }
}
