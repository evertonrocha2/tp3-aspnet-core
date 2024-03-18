using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using tp3.DAL;
using tp3.Models;

namespace tp3.Controllers
{
    public class ComputadoresController : Controller
    {
        private readonly Contexto _context;

        public ComputadoresController(Contexto context)
        {
            _context = context;
        }

        // GET: Computadores
        public async Task<IActionResult> Index()
        {
            return View(await _context.computadores.ToListAsync());
        }

        // GET: Computadores/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computadores = await _context.computadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computadores == null)
            {
                return NotFound();
            }

            return View(computadores);
        }

        // GET: Computadores/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Computadores/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Marca,Processador,PlacaMae,Memoria,Hd,NumeroPatrimonio,DataDeCompra")] Computadores computadores)
        {
            if (ModelState.IsValid)
            {
                _context.Add(computadores);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(computadores);
        }

        // GET: Computadores/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computadores = await _context.computadores.FindAsync(id);
            if (computadores == null)
            {
                return NotFound();
            }
            return View(computadores);
        }

        // POST: Computadores/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Marca,Processador,PlacaMae,Memoria,Hd,NumeroPatrimonio,DataDeCompra")] Computadores computadores)
        {
            if (id != computadores.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(computadores);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComputadoresExists(computadores.Id))
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
            return View(computadores);
        }

        // GET: Computadores/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var computadores = await _context.computadores
                .FirstOrDefaultAsync(m => m.Id == id);
            if (computadores == null)
            {
                return NotFound();
            }

            return View(computadores);
        }

        // POST: Computadores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var computadores = await _context.computadores.FindAsync(id);
            if (computadores != null)
            {
                _context.computadores.Remove(computadores);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComputadoresExists(int id)
        {
            return _context.computadores.Any(e => e.Id == id);
        }
    }
}
