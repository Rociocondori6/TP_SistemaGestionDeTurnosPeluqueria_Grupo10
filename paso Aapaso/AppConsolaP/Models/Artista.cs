using System;
using System.Collections.Generic;
using System.Text;

namespace AppConsolaP.Models
{
    public  class Artista
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public ICollection<Cancion> Canciones { get; set; } = new List<Cancion>();
    }
}
    