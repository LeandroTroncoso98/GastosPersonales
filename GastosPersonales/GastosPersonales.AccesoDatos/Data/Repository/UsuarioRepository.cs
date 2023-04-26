using GastosPersonales.AccesoDatos.Data;
using GastosPersonales.AccesoDatos.Data.IRepository;
using GastosPersonales.Models.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationDbContext _db;
        public UsuarioRepository(ApplicationDbContext db) 
        {
            _db= db;
        }

        public async Task<Usuario> GetForEmail(string email)
        {
            return await _db.Usuario.FirstOrDefaultAsync(u => u.CorreoElectronico == email);
        }

        public async Task<Usuario> GetUsuario(string email, string password)
        {
            return await _db.Usuario.FirstOrDefaultAsync(u => u.CorreoElectronico == email && u.Contraseña == password);
        }

        public async void GuardarUsuario(Usuario usuario)
        {
            await _db.Usuario.AddAsync(usuario);           
        }

        public async Task<bool> UsuarioExiste(string email)
        {
            return await _db.Usuario.AnyAsync(e => e.CorreoElectronico == email);
        }
    }
}
