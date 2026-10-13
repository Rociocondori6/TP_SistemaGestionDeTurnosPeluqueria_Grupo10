using AppConsolaP.Models;
using Microsoft.EntityFrameworkCore; 


namespace AppConsolaP.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Artista> Artistas { get; set; }
    public DbSet<Cancion> Canciones { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {

            optionsBuilder.UseSqlServer("Server=localhost;Database=MusicaDb;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}