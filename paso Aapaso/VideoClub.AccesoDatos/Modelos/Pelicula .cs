using System;
using System.Collections.Generic;
using System.Text;

namespace VideoClub.AccesoDatos.Modelos
{ 
     public  class Pelicula
    {
        public int Id { get; set; }
        public required string Titulo { get; set; }
        public required string Autor { get; set; }
        public int CantidadDisponible { get; set; }
        public ICollection<AlquilerPelicula> AlquilerPeliculas { get; set; } = new List<AlquilerPelicula>();
    }
}
