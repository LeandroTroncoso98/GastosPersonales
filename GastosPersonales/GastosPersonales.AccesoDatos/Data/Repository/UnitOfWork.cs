using GastosPersonales.AccesoDatos.Data;
using GastosPersonales.AccesoDatos.Data.IRepository;
using GastosPersonales.AccesoDatos.Data.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;

        public UnitOfWork(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;
            Categoria = new CategoriaRepository(_context);
            Usuario = new UsuarioRepository(_context);
        }
        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
        public IUsuarioRepository Usuario { get; private set; }
        public ICategoriaRepository Categoria { get; private set; }
        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
