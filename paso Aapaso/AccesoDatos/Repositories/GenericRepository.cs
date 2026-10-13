using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AccesoDatos.Data;
using AccesoDatos.Models;
using SQLitePCL;

namespace AccesoDatos.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly appDbContext _context;
        public GenericRepository(appDbContext context)
        {
            _context = context;
        }
        public void Agregar(T entidad)
        {
            _context.Set<T>().Add(entidad);
            _context.SaveChanges();
        }

        public List<T> ObtenerTodos()
        {
            return _context.Set<T>().ToList();
        }


    }
}
