using System;
using System.Collections.Generic;
using System.Text;

namespace VideoClub.AccesoDatos.Modelos
{
    public class Socio
    {
        public int Id { get; set; }
        public required string Nombre { get; set; }
        public  required string Apellido { get; set; }
        public required string  Dni { get; set; }
        public string?  Telefono { get; set; }
        public ICollection<Alquiler> Alquileres { get; set; } = new List<Alquiler>();
    }
}
