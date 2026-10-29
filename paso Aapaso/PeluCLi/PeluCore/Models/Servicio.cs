using System;
using System.Collections.Generic;
using System.Text;

namespace PeluCore.Models
{
    public  class Servicio
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int DuracionMinima { get; set; }

        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}
