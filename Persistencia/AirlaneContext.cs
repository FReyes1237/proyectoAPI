using System;
using System.Collections.Generic;
using System.Text;
using Dominio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

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

            modelBuilder.Entity<Usuario>().HasKey(ci => new { ci.UserID });

            modelBuilder.Entity<Cliente>().HasKey(ci => new { ci.ClienteID });

            modelBuilder.Entity<Aeropuerto>().HasKey(ci => new { ci.aeropuertoID });

            modelBuilder.Entity<Pais>().HasKey(ci => new { ci.paisID });

            modelBuilder.Entity<Ciudad>().HasKey(ci => new { ci.ciudadID });

            modelBuilder.Entity<ClaseViaje>().HasKey(ci => new { ci.claseViajeID });

            modelBuilder.Entity<Vuelo>().HasKey(ci => new { ci.vueloID });

            modelBuilder.Entity<estadoVuelo>().HasKey(ci => new { ci.estadoVueloID });

            modelBuilder.Entity<Butaca>().HasKey(ci => new { ci.butacaID });

            modelBuilder.Entity<precioButaca>().HasKey(ci => new { ci.precioButacaID });

            modelBuilder.Entity<estadoButaca>().HasKey(ci => new { ci.estadoButacaID });

            modelBuilder.Entity<FormaPago>().HasKey(ci => new { ci.modoPagoID });

            modelBuilder.Entity<Reserva>().HasKey(ci => new { ci.reservaID });

            modelBuilder.Entity<Factura>().HasKey(ci => new { ci.facturaID });
        }

        public DbSet<Aeronave> Aeronave { get; set; }

        public DbSet<Aeropuerto> Aeropuerto { get; set; }

        public DbSet<Pais> Pais { get; set; }

        public DbSet<Ciudad> Ciudad { get; set; }

        public DbSet<Usuario> Usuario { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<ClaseViaje> ClaseViaje { get; set; }

        public DbSet<Vuelo> Vuelo { get; set; }

        public DbSet<estadoVuelo> estadoVuelo { get; set; }

        public DbSet<Butaca> Butaca { get; set; }

        public DbSet<precioButaca> precioButaca { get; set; }

        public DbSet<estadoButaca> estadoButaca { get; set; }

        public DbSet<FormaPago> FormaPago { get; set; }

        public DbSet<Reserva> Reserva { get; set; }

        public DbSet<Factura> Factura { get; set; }
    }
}