using GastosPersonales.AccesoDatos.Data;
using GastosPersonales.AccesoDatos.Data.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Repository
{
    public class Repositorio<T> : IRepositorio<T> where T : class
    {
        private readonly ApplicationDbContext _context;
        internal DbSet<T> _dbSet;
        public Repositorio(ApplicationDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public async Task Add(T item)
        {
            await _dbSet.AddAsync(item);
        }

        public async Task<T> Get(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _dbSet.ToListAsync();
        }

        public async Task Remove(int id)
        {
            var item = await _dbSet.FindAsync(id);
            Remove(item);
        }

        public void Remove(T item)
        {
            _dbSet.Remove(item);
        }
    }
}
