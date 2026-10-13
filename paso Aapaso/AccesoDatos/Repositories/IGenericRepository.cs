using System;
using System.Collections.Generic;
using System.Text;

namespace AccesoDatos.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        void Agregar(T entidad);
        List<T> ObtenerTodos();

    }
}
