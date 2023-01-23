using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EncodeApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EncodeApp.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly DbPruebaTecnicaContext _context;

        public UsuarioService(DbPruebaTecnicaContext context)
        {
            _context = context;
        }

        public async Task<int> CreateUsuarioAsync(Usuario usuario)
        {
            _context.Add(usuario);
            return await _context.SaveChangesAsync();
        }

        public async Task<bool> DeleteUsuarioAsync(long id)
        {
            var usuario = await GetUsuarioById(id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<List<Usuario>> GetAllUsuarios()
        {
            return await _context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> GetUsuarioById(long id)
        {
            return await _context.Usuarios
            .FirstOrDefaultAsync(m => m.IdUsuario == id);
        }

        public async Task<int> UpdateUsuarioAsync(Usuario usuario)
        {
            _context.Update(usuario);
            return await _context.SaveChangesAsync();
        }

        private bool UsuarioExists(long id)
        {
            return _context.Usuarios.Any(e => e.IdUsuario == id);
        }
    }
}