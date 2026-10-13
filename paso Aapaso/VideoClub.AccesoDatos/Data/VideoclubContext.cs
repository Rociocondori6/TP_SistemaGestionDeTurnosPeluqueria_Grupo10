using Microsoft.EntityFrameworkCore;
using VideoClub.AccesoDatos.Modelos;

namespace VideoClub.AccesoDatos
{
    public class VideoclubContext : DbContext
    {
        public DbSet<Socio> Socios { get; set; }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Alquiler> Alquileres { get; set; }
        public DbSet<AlquilerPelicula> AlquilerPeliculas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=videoclub.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Definimos una clave primaria compuesta usando los IDs de Alquiler y Pelicula
            modelBuilder.Entity<AlquilerPelicula>()
                .HasKey(ap => new { ap.AlquilerId, ap.PeliculaId });
        }
    }
}