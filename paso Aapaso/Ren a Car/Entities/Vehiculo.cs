using System;
using System.Collections.Generic;
using System.Text;

namespace Ren_a_Car.Entities
{
    internal class Vehiculo
    {
        public int Id { get; set; }
        public string Patente { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal PrecioPorDia { get; set; }
        public int CantidadDisponible { get; set; }
        public string Estado { get; set; }

        public ICollection<AlquilerVehiculo> AlquilerVehiculos { get; set; }>
    }
}
