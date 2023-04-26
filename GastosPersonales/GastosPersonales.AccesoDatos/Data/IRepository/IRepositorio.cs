using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Data.IRepository
{
    public interface IRepositorio<T> where T : class
    {
        Task<T> Get(int id);
        Task<IEnumerable<T>> GetAll();
        Task Add(T item);
        Task Remove(int id);
        void Remove(T item);
    }
}
