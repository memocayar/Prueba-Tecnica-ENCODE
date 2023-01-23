using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EncodeApp.Models;

namespace EncodeApp.Controllers
{
    // public class ActividadesController : Controller
    // {
    //     private readonly DbPruebaTecnicaContext _context;

    //     public ActividadesController(DbPruebaTecnicaContext context)
    //     {
    //         _context = context;
    //     }

    //     GET: Actividades
    //     public async Task<IActionResult> Index()
    //     {
    //           return View(await _context.Actividades.ToListAsync());
    //     }

    //     GET: Actividades/Details/5
    //     public async Task<IActionResult> Details(int? id)
    //     {
    //         if (id == null || _context.Actividades == null)
    //         {
    //             return NotFound();
    //         }

    //         var actividad = await _context.Actividades
    //             .FirstOrDefaultAsync(m => m.IdActividad == id);
    //         if (actividad == null)
    //         {
    //             return NotFound();
    //         }

    //         return View(actividad);
    //     }

    //     GET: Actividades/Create
    //     public IActionResult Create()
    //     {
    //         return View();
    //     }

    //     POST: Actividades/Create
    //     To protect from overposting attacks, enable the specific properties you want to bind to.
    //     For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //     [HttpPost]
    //     [ValidateAntiForgeryToken]
    //     public async Task<IActionResult> Create([Bind("IdActividad,CreateDate,IdUsuario,Actividad1")] Actividad actividad)
    //     {
    //         if (ModelState.IsValid)
    //         {
    //             _context.Add(actividad);
    //             await _context.SaveChangesAsync();
    //             return RedirectToAction(nameof(Index));
    //         }
    //         return View(actividad);
    //     }

    //     GET: Actividades/Edit/5
    //     public async Task<IActionResult> Edit(int? id)
    //     {
    //         if (id == null || _context.Actividades == null)
    //         {
    //             return NotFound();
    //         }

    //         var actividad = await _context.Actividades.FindAsync(id);
    //         if (actividad == null)
    //         {
    //             return NotFound();
    //         }
    //         return View(actividad);
    //     }

    //     POST: Actividades/Edit/5
    //     To protect from overposting attacks, enable the specific properties you want to bind to.
    //     For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
    //     [HttpPost]
    //     [ValidateAntiForgeryToken]
    //     public async Task<IActionResult> Edit(int id, [Bind("IdActividad,CreateDate,IdUsuario,Actividad1")] Actividad actividad)
    //     {
    //         if (id != actividad.IdActividad)
    //         {
    //             return NotFound();
    //         }

    //         if (ModelState.IsValid)
    //         {
    //             try
    //             {
    //                 _context.Update(actividad);
    //                 await _context.SaveChangesAsync();
    //             }
    //             catch (DbUpdateConcurrencyException)
    //             {
    //                 if (!ActividadExists(actividad.IdActividad))
    //                 {
    //                     return NotFound();
    //                 }
    //                 else
    //                 {
    //                     throw;
    //                 }
    //             }
    //             return RedirectToAction(nameof(Index));
    //         }
    //         return View(actividad);
    //     }

    //     GET: Actividades/Delete/5
    //     public async Task<IActionResult> Delete(int? id)
    //     {
    //         if (id == null || _context.Actividades == null)
    //         {
    //             return NotFound();
    //         }

    //         var actividad = await _context.Actividades
    //             .FirstOrDefaultAsync(m => m.IdActividad == id);
    //         if (actividad == null)
    //         {
    //             return NotFound();
    //         }

    //         return View(actividad);
    //     }

    //     POST: Actividades/Delete/5
    //     [HttpPost, ActionName("Delete")]
    //     [ValidateAntiForgeryToken]
    //     public async Task<IActionResult> DeleteConfirmed(int id)
    //     {
    //         if (_context.Actividades == null)
    //         {
    //             return Problem("Entity set 'DbPruebaTecnicaContext.Actividades'  is null.");
    //         }
    //         var actividad = await _context.Actividades.FindAsync(id);
    //         if (actividad != null)
    //         {
    //             _context.Actividades.Remove(actividad);
    //         }
            
    //         await _context.SaveChangesAsync();
    //         return RedirectToAction(nameof(Index));
    //     }

    //     private bool ActividadExists(int id)
    //     {
    //       return _context.Actividades.Any(e => e.IdActividad == id);
    //     }
    // }
}
