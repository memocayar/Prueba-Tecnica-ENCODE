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
    public class ActividadesController : Controller
    {
        private readonly IActvidadservice _actvidadservice;

        public ActividadesController(IActvidadservice actvidadservice)
        {
            _actvidadservice = actvidadservice;
        }

        // GET: Actividades
        public async Task<IActionResult> Index()
        {
            return View(_actvidadservice.GetAll());
        }

        // GET: Actividades/Details/5
        public async Task<IActionResult> Details(int id)
        {
            var actividad = await _actvidadservice.GetById(id);

            if (actividad == null)
            {
                return NotFound();
            }

            return View(actividad);
        }

        // GET: Actividades/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Actividades/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deleted = _actvidadservice.Delete(id);
            if (await deleted == false)
            {
                return NotFound();
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
