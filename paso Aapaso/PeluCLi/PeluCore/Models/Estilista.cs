using System;
using System.Collections.Generic;
using System.Text;

namespace PeluCore.Models
{
     public  class Estilista
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellido { get; set; } = string.Empty;
        public string? Especialidad { get; set; } 

        public ICollection<Turno> Turnos { get; set; } = new List<Turno>();
    }
}
