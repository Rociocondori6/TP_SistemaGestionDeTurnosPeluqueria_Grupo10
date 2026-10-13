using System;
using System.Collections.Generic;

namespace VideoclubExamen.Modelos
{
    public class Socio
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string? Telefono { get; set; }
        public string? Email { get; set; }

        // Propiedad de navegación: Un socio puede tener muchos alquileres
        public ICollection<Alquiler> Alquileres { get; set; } = new List<Alquiler>();
    }
}