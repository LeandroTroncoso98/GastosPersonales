﻿using GastosPersonales.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastosPersonales.AccesoDatos.Data.IRepository
{
    public interface IUsuarioRepository 
    {
        Task<Usuario> GetUsuario(string email, string password);
        void GuardarUsuario(Usuario usuario);
        Task<bool> UsuarioExiste(string email);
        Task<Usuario> GetForEmail(string email);
    }
}
