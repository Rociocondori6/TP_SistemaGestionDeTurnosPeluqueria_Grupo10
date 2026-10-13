using System;
using System.Collections.Generic;

namespace VideoclubExamen.Modelos
{
    public class Alquiler
    {
        public int Id { get; set; }
        public DateTime FechaAlquiler { get; set; }
        public decimal MontoBase { get; set; }

        public int SocioId { get; set; }
        public Socio? Socio { get; set; }

        public ICollection<AlquilerPelicula> AlquilerPeliculas { get; set; } = new List<AlquilerPelicula>();
    }
}