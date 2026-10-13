using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos 
{
    public class ApplitionsDbContext : DbContext
    {

        public DbSet<Artista> Artistas { get; set; }
        public DbSet<Canciones> Canciones { get; set; }
        
        protected ApplitionsDbContext(DbContextOptions<ApplitionsDbContext> options) : base(options)
        {
            OptionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ParcialMusicaDb;Trusted_Connection=True;");
        }

    }
}