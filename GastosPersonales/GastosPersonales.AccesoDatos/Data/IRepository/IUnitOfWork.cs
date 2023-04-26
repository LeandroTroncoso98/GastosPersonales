using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Data.IRepository
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IUsuarioRepository Usuario { get; }
        ICategoriaRepository Categoria { get; }
        Task Save();
    }
}
