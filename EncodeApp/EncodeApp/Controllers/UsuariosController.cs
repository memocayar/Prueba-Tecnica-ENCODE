using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EncodeApp.Models;
using EncodeApp.Services;


namespace EncodeApp.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuariosController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            return View(await _usuarioService.GetAllUsuarios());
        }

        // GET: Usuarios/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _usuarioService.GetUsuarioById((long)id);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdUsuario,Nombre,Apellido,CorreoElectronico,FechaNacimiento,Telefono,Pais,Contacto")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                await _usuarioService.CreateUsuarioAsync(usuario);
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = await _usuarioService.GetUsuarioById((long)id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: Usuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, [Bind("IdUsuario,Nombre,Apellido,CorreoElectronico,FechaNacimiento,Telefono,Pais,Contacto")] Usuario usuario)
        {
            if (id != usuario.IdUsuario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                await _usuarioService.UpdateUsuarioAsync(usuario);
                // try
                // {
                //     _context.Update(usuario);
                //     await _context.SaveChangesAsync();
                // }
                // catch (DbUpdateConcurrencyException)
                // {
                //     if (!UsuarioExists(usuario.IdUsuario))
                //     {
                //         return NotFound();
                //     }
                //     else
                //     {
                //         throw;
                //     }
                // }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuario = _usuarioService.GetUsuarioById((long)id);

            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // DELETE: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (await _usuarioService.DeleteUsuarioAsync(id))
            {
                return RedirectToAction(nameof(Index));
            }
            return Problem("Entity set 'DbPruebaTecnicaContext.Usuarios'  is null.");
        }
    }
}
