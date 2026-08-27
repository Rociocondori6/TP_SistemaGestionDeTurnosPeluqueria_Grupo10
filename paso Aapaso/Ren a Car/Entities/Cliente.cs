using System;
using System.Collections.Generic;
using System.Text;

namespace Ren_a_Car.Entities
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Telefono { get; set; }
        public string LicenciaConducir { get; set; }

        public ICollection<Alquiler> Alquileres { get; set; }
    }
}
