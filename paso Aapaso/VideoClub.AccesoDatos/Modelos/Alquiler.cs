using System;
using System.Collections.Generic;
using System.Text;

namespace VideoClub.AccesoDatos.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public int SocioId { get; set; }
        public Socio? Socio { get; set; }
        
        public DateTime FechaAlquiler { get; set; }
        public DateTime FechaDevolucionPrevista { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }
        public decimal MontoBase { get; set; }
        public ICollection<AlquilerPelicula> AlquilerPeliculas { get; set; } = new List<AlquilerPelicula>();

    }
}
