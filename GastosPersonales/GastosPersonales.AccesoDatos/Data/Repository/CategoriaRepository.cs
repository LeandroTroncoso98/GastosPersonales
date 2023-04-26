using GastosPersonales.AccesoDatos.Data.IRepository;
using GastosPersonales.AccesoDatos.Repository;
using GastosPersonales.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Data.Repository
{
    public class CategoriaRepository : Repositorio<Categoria>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _context;
        public CategoriaRepository(ApplicationDbContext context) : base(context) 
        {
            _context = context;
        }
        public async Task Update(Categoria categoria)
        {
            var categoriaDB = await _context.Categoria.FirstOrDefaultAsync(m => m.Categoria_Id == categoria.Categoria_Id);
            categoriaDB.NombreCategoria = categoria.NombreCategoria;
            _context.Update(categoriaDB);
            await _context.SaveChangesAsync();
        }
        public async Task<bool> Existe(string nombreCategoria)
        {
            return await _context.Categoria.AnyAsync(m => m.NombreCategoria == nombreCategoria);
        }
    }
}
