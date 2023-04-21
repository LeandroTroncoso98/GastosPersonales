using GastosPersonales.AccesoDatos.Data;
using GastosPersonales.AccesoDatos.Data.IRepository;
using GastosPersonales.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Repository
{
    public class UsuarioRepository : Repositorio<Usuario>, IUsuarioRepository
    {
        private readonly ApplicationDbContext _db;
        public UsuarioRepository(ApplicationDbContext db) : base(db)
        {
            _db= db;
        }              
    }
}
