using System;
using System.Collections.Generic;
using System.Text;

namespace PeluCore.Data
{
    public  class ApplicacionDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Estilista> Estilistas { get; set; }
        public DbSet<Servicio> Servicios { get; set; }
        public DbSet<Turno> Turnos { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=peluqueria.db");
            }
        }
    }
}
