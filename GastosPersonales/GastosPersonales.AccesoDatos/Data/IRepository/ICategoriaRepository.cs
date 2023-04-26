using GastosPersonales.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Data.IRepository
{
    public interface ICategoriaRepository : IRepositorio<Categoria>
    {
        Task Update(Categoria categoria);
        Task<bool> Existe(string nombreCategoria);
    }
}
