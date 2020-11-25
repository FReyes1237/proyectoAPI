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

            modelBuilder.Entity<Usuario>().HasKey(ci => new { ci.Username });

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

        public DbSet<Dominio.Aeropuerto> Aeropuerto { get; set; }

        public DbSet<Dominio.Pais> Pais { get; set; }

        public DbSet<Dominio.Ciudad> Ciudad { get; set; }

        public DbSet<Dominio.Usuario> Usuario { get; set; }

        public DbSet<Dominio.ClaseViaje> ClaseViaje { get; set; }

        public DbSet<Dominio.Vuelo> Vuelo { get; set; }

        public DbSet<Dominio.estadoVuelo> estadoVuelo { get; set; }

        public DbSet<Dominio.Butaca> Butaca { get; set; }

        public DbSet<Dominio.precioButaca> precioButaca { get; set; }

        public DbSet<Dominio.estadoButaca> estadoButaca { get; set; }

        public DbSet<Dominio.FormaPago> FormaPago { get; set; }

        public DbSet<Dominio.Reserva> Reserva { get; set; }

        public DbSet<Dominio.Factura> Factura { get; set; }







    }
}
