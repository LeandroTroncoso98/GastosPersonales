using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Data.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IUsuarioRepository Usuario { get; }
        void Save();
    }
}
