using System;
using System.Collections.Generic;
using System.Text;

namespace Ren_a_Car.Data
{
    internal class RentACarDbContext : DbContext
    {
        public DbSet<Vehiculo> Vehiculos { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<AlquilerVehiculo> AlquilerVehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=rentacar.db");
        }

        protected overide void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuider.Entity<AlquilerVehiculo>()
                .HasKey(av => new { av.AlquilerId, av.VehiculoId });

            modelBuilder.Entity<AlquilerVehiculo>()
                .HasOne(av => av.Alquiler)
                .WithMany(a => a.AlquilerVehiculos)
                .HasForeignKey(av => av.AlquilerId);

            modelBuider.Entity<AlquilerVehiculo>()
                .HasOne(av => av.Vehiculo)
                .WithMany(v => v.AlquilerVehiculos)
                .HasForeignKey(av => av.VehiculoId);
        }
       
    }
}
