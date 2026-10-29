using Microsoft.EntityFrameworkCore;
using PeluCore.Data;
using System.Collections.Generic;
using System.Linq;

namespace PeluCore.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _context;

        public GenericRepository(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}