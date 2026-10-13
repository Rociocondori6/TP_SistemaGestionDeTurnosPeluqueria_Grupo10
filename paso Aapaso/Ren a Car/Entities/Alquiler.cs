using System;
using System.Collections.Generic;
using System.Text;

namespace Ren_a_Car.Entities
{
    internal class Alquiler
    {
        public int Id { get; set; }
        public int Cliente { get; set; }
        public Cliente Cliente { get; set; }

        public DateTime FechaInicio { get; set; }
        public DateTime FechaDevolucionPrevista { get; set; }
        public DateTime? FechaDevolucionReal { get; set; }

        public decimal PorcentaJeSeguro { get; set; }
        public decimal MontoTotal { get; set; }
        public bool Devuelto { get; set; } = false;

        public ICollection<AlquilerVehiculo> AlquilerVehiculos { get; set; }
    }
}
