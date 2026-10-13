using System;
using System.Collections.Generic;
using System.Text;

namespace PeluCore.Models
{
    public  class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }

        public ICollection<Turno> Turnos  { get; set; }
    }
}
