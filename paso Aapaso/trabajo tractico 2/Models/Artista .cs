using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    public  class Artista 
    { 
       public int Id { get; set; }
        public int Nombre { get; set; }

        public ICollection<Canciones> cansiones { get; set; }
    }
}
