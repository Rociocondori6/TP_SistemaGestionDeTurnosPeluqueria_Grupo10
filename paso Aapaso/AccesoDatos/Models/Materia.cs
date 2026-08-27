using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Models
{
    public class Materia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public int ProfesorId { get; set; }
        public Profesor Profesor { get; set; }
    }
}
