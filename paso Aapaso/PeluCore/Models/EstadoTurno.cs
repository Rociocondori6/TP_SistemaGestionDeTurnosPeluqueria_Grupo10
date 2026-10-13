using System;
using System.Collections.Generic;
using System.Text;

namespace PeluCore.Models
{
    public class EstadoTurno
    {
        public enum EstadoTurno
        {
            Pendiente,
            Confirmado,
            Cancelado,
            Completado
        }
    }
}
