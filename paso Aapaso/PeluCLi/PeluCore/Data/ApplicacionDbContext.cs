using Microsoft.EntityFrameworkCore;
using PeluCore.Models;

namespace PeluCore.Data
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; } = null!;
        public DbSet<Estilista> Estilistas { get; set; } = null!;

        public DbSet<Servicio> Servicios { get; set; } = null!;
        public DbSet<Turno> Turnos { get; set; } = null!;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite("Data Source=peluqueria.db");
            }
        }
    }
}