using Microsoft.EntityFrameworkCore;
using Pav.Parcial2Rec.Dominio.Entidades;
using System;

namespace Pav.Parcial2.Infraestructura.Datos
{
    public class PavParcial2Context : DbContext
    {
        public static string CadenaDeConexion { get; set; } = "Server=(localdb)\\MSSQLLocalDB;Database=PavCotizaciones";

        public PavParcial2Context(DbContextOptions<PavParcial2Context> options) : base(options)
        {
        }

        public DbSet<Cotizacion> Cotizaciones { get; set; }
        public DbSet<Registro> Registros { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cotizacion>()
                .ToTable("Cotizaciones")
                .HasKey(c => c.Id);
            modelBuilder.Entity<Cotizacion>()
                .Property(c => c.Valor).HasPrecision(18, 2).IsRequired();
            modelBuilder.Entity<Cotizacion>()
                .Property(c => c.FechaHora).IsRequired();
            modelBuilder.Entity<Cotizacion>()
                .Property(c => c.RegistroId).IsRequired();

            modelBuilder.Entity<Registro>()
                .ToTable("Registros")
                .HasKey(r => r.Id);
            modelBuilder.Entity<Registro>()
                .Property(r => r.FechaHoraInicio).IsRequired();
            modelBuilder.Entity<Registro>()
                .Property(r => r.FechaHoraFin);

            modelBuilder.Entity<Cotizacion>()
                .HasOne<Registro>()
                .WithMany(r => r.Cotizaciones)
                .HasForeignKey(c => c.RegistroId);

            
        }
    }
}
