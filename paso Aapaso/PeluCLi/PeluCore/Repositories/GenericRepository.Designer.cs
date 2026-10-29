// 1. El Contrato
public interface IGenericRepository<T>
{
    List<T> ObtenerTodos();
}

// 2. La Implementación
public class GenericRepository<T> : IGenericRepository<T>
{
    public List<T> ObtenerTodos()
    {
        return _context.Set<T>().ToList();
    }
}

