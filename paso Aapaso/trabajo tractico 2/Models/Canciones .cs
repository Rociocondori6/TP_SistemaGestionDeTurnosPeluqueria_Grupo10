using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos
{
    internal class Canciones 
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Duracion { get; set; }
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
        
       
           
       
    }
}
