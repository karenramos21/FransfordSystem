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
    public class ExamenesController : Controller
    {
        private readonly FransforDbContext _context;

        public ExamenesController(FransforDbContext context)
        {
            _context = context;
        }

        // GET: Examenes
        public async Task<IActionResult> Index()
        {
            return _context.Examen != null ?
                        View(await _context.Examen.ToListAsync()) :
                        Problem("Entity set 'FransforDbContext.Examen'  is null.");
        }

        // GET: Examenes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Examen == null)
            {
                return NotFound();
            }

            var examen = await _context.Examen
                .FirstOrDefaultAsync(m => m.idExamen == id);

            //Descripciones de exámenes
            //ViewBag.Descripciones = await _context.Descripcion.Select(x => x.idExamen == id).ToListAsync();
            ViewBag.Descripciones = await _context.Descripcion.Where(o => o.idExamen == id).ToListAsync();
            //ViewBag.Descripciones = await _context.Descripcion.Select
            //ViewBag.Descripciones = await _context.Descripcion.ToListAsync();
            //ViewBag.Descripciones = new SelectList(_context.Descripcion.
            //Where(o => o.idExamen == id), "Descripcion", "Valor minimo", "Valor maximo");

            //Nombre de la unidad
            //ViewBag.Unidades = await _context.Unidad.Where(p => p.idUnidad == ).ToListAsync();

            if (examen == null)
            {
                return NotFound();
            }

            return View(examen);
        }

        // GET: Examenes/Create
        public IActionResult Create()
        {
            //Genera lista de categorias
            List<Categoria> categoriaLista = new List<Categoria>();
            categoriaLista = (from categoria in _context.Categoria select categoria).ToList();
            categoriaLista.Insert(0, new Categoria { IdCategoria = 0, nombreCategoria = "Seleccionar" });
            ViewBag.categoriaDeLista = categoriaLista;
            return View();
        }

        // POST: Examenes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("idExamen,idCategoria,nombreExamen,PrecioExamen,nombreMuestra")] Examen examen)
        {
            if (ModelState.IsValid)
            {
                _context.Add(examen);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Create));
            }
            return View(examen);
        }

        // GET: Examenes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Examen == null)
            {
                return NotFound();
            }

            var examen = await _context.Examen.FindAsync(id);
            if (examen == null)
            {
                return NotFound();
            }
            //Genera lista de categorias
            List<Categoria> categoriaLista = new List<Categoria>();
            categoriaLista = (from categoria in _context.Categoria select categoria).ToList();
            categoriaLista.Insert(0, new Categoria { IdCategoria = 0, nombreCategoria = "Seleccionar" });
            ViewBag.categoriaDeLista = categoriaLista;

            return View(examen);
        }

        // POST: Examenes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("idExamen,idCategoria,nombreExamen,PrecioExamen,nombreMuestra")] Examen examen)
        {
            if (id != examen.idExamen)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(examen);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamenExists(examen.idExamen))
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
            return View(examen);
        }

        // GET: Examenes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Examen == null)
            {
                return NotFound();
            }

            //var examen = _context.Examen.OrderBy(e => e.idExamen).Include(e => e.descripcion).First();

            var examen = await _context.Examen.FirstOrDefaultAsync(m => m.idExamen == id);

            //Descripciones de exámenes
            ViewBag.Descripciones = await _context.Descripcion.Where(o => o.idExamen == id).ToListAsync();
            if (examen == null)
            {
                return NotFound();
            }

            return View(examen);
        }

        // POST: Examenes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Examen == null)
            {
                return Problem("Entity set 'FransforDbContext.Examen'  is null.");
            }
            var examen = await _context.Examen.FindAsync(id);
            var descripcion = await _context.Descripcion.Where(d => d.idExamen == id).FirstOrDefaultAsync();
            //var descripcion = await _context.Examen.OrderBy(d => d.idExamen == id).Include(d => d.descripcion).FirstAsync();
            if (examen != null)
            {
                _context.Examen.Remove(examen);
                if(descripcion != null)
                {
                    _context.Descripcion.Remove(descripcion);
                }
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ExamenExists(int id)
        {
            return (_context.Examen?.Any(e => e.idExamen == id)).GetValueOrDefault();
        }
    }
}
