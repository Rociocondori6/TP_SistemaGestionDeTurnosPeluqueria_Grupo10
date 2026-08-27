using System.Collections.Generic;
using System.Linq.Expressions;

namespace AccesoDatos.Repositories
{
    public interface IGenericRepository<T> where T : class
    {
        List<T> ObtenerTodos();
        T ObtenerPorId(int id);
        void Agregar(T entidad);
        void Actualizar(T entidad);
        void Eliminar(int id);

        List<T> ObtenerTodosCon(string includeProperties = "");
    }
}
