using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsolaP.Models
{
    public  class Cancion
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public int Duracion { get; set; }

        public int ArtistaId { get; set; }
        public Artista? Artista { get; set; }
    }
}
