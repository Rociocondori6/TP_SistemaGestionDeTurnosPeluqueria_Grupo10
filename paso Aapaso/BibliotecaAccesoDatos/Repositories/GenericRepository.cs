using System.Security.Cryptography.X509Certificates;
using AccesoDatos.Data;
using Microsoft.EntityFrameworkCore;

namespace AccesoDatos.Repositories;

public class GenericRepository<T> where T : class
{
    private readonly AplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public GenericRepository(AplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public List<T> ObtenerTodos()
    {
        return _dbSet.ToList();
    }

    public void Agregar(T entidad)
    {
        _dbSet.Add(entidad);
        _context.SaveChanges();
    }
    public List<T> ObtenerTodosCon(string includeProperties = "")
    {
        IQueryable<T> query = _dbSet;
        foreach (var includeProperty in includeProperties.Split(new char[] { ',' }, System.StringSplitOptions.RemoveEmptyEntries))
        {
            query = query.Include(includeProperty.Trim());
        }
        return query.ToList();
    }
}


    