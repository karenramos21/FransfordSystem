using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FransfordSystem;
using FransfordSystem.Models;

namespace FransfordSystem.Controllers
{
    public class TrabajadoresController : Controller
    {
        private readonly FransforDbContext _context;

        public TrabajadoresController(FransforDbContext context)
        {
            _context = context;
        }

        // GET: Trabajadores
        public async Task<IActionResult> Index()
        {
              return _context.Trabajador != null ? 
                          View(await _context.Trabajador.ToListAsync()) :
                          Problem("Entity set 'FransforDbContext.Trabajador'  is null.");
        }

        // GET: Trabajadores/Details/5
        public async Task<IActionResult> Mostrar(int? id)
        {
            if (id == null || _context.Trabajador == null)
            {
                return NotFound();
            }

            var trabajador = await _context.Trabajador
                .FirstOrDefaultAsync(m => m.IdTrabajador == id);
            if (trabajador == null)
            {
                return NotFound();
            }

            return View(trabajador);
        }

        // GET: Trabajadores/Create
        public IActionResult Crear()
        {
            return View();
        }

        // POST: Trabajadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Crear([Bind("IdTrabajador,nombreTrabajador,apellidoTrabajador,fechaNacimiento,genero,dui,correo,cuentaBancaria")] Trabajador trabajador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trabajador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trabajador);
        }

        // GET: Trabajadores/Edit/5
        public async Task<IActionResult> Editar(int? id)
        {
            if (id == null || _context.Trabajador == null)
            {
                return NotFound();
            }

            var trabajador = await _context.Trabajador.FindAsync(id);
            if (trabajador == null)
            {
                return NotFound();
            }
            return View(trabajador);
        }

        // POST: Trabajadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Editar(int id, [Bind("IdTrabajador,nombreTrabajador,apellidoTrabajador,fechaNacimiento,genero,dui,correo,cuentaBancaria")] Trabajador trabajador)
        {
            if (id != trabajador.IdTrabajador)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trabajador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrabajadorExists(trabajador.IdTrabajador))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(trabajador);
        }

        // GET: Trabajadores/Delete/5
        public async Task<IActionResult> Eliminar(int? id)
        {
            if (id == null || _context.Trabajador == null)
            {
                return NotFound();
            }

            var trabajador = await _context.Trabajador
                .FirstOrDefaultAsync(m => m.IdTrabajador == id);
            if (trabajador == null)
            {
                return NotFound();
            }

            return View(trabajador);
        }

        // POST: Trabajadores/Delete/5
        [HttpPost, ActionName("Eliminar")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Trabajador == null)
            {
                return Problem("Entity set 'FransforDbContext.Trabajador'  is null.");
            }
            var trabajador = await _context.Trabajador.FindAsync(id);
            if (trabajador != null)
            {
                _context.Trabajador.Remove(trabajador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrabajadorExists(int id)
        {
          return (_context.Trabajador?.Any(e => e.IdTrabajador == id)).GetValueOrDefault();
        }
    }
}
