using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace Persistencia
{
    public class AirlaneContext:DbContext
    {
        public AirlaneContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aeronave>().HasKey(ci => new { ci.aeronaveID });
        }

        public DbSet<Aeronave> Aeronave { get; set; }
    }
}
