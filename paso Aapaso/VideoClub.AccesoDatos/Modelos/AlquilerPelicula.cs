using System;
using System.Collections.Generic;
using System.Text;
using VideoClub.AccesoDatos;

namespace VideoClub.AccesoDatos.Modelos
{
    public  class AlquilerPelicula
    {
        public int AlquilerId { get; set; }
        public Alquiler? Alquiler { get; set; }
        public int PeliculaId { get; set; }
        public Pelicula? Pelicula { get; set; }
    }
}
