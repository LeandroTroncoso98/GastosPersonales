using GastosPersonales.AccesoDatos.Data;
using GastosPersonales.AccesoDatos.Data.IRepository;
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
            Usuario = new UsuarioRepository(_context);
        }
        public async void Dispose()
        {
            await _context.DisposeAsync();
        }
        public IUsuarioRepository Usuario { get; private set; }
        public async void Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
