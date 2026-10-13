using System;
using System.Collections.Generic;
using System.Text;

namespace Ren_a_Car.Entities
{
    internal class AlqulerVehiculo
    {
        public int AlquilerId { get; set; }
        public Alquiler Alquiler { get; set; }

        public int VehiculoId { get; set; }
        public Vehiculo Vehiculo { get; set; }

        public int CantidadDias { get; set; }
        public decimal SubTotal { get; set; }

    }
}
