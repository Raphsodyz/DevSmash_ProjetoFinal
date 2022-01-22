#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DevSmash___Projeto_Final;
using DevSmash___Projeto_Final.Models.Entidades;

namespace DevSmash___Projeto_Final.Controllers
{
    public class MidiasController : Controller
    {
        private readonly SiteContext _context;

        public MidiasController(SiteContext context)
        {
            _context = context;
        }

        // GET: Midias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Midias.ToListAsync());
        }

        // GET: Midias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var midia = await _context.Midias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (midia == null)
            {
                return NotFound();
            }

            return View(midia);
        }

        // GET: Midias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Midias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Alt,Link")] Midia midia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(midia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(midia);
        }

        // GET: Midias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var midia = await _context.Midias.FindAsync(id);
            if (midia == null)
            {
                return NotFound();
            }
            return View(midia);
        }

        // POST: Midias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Alt,Link")] Midia midia)
        {
            if (id != midia.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(midia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MidiaExists(midia.Id))
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
            return View(midia);
        }

        // GET: Midias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var midia = await _context.Midias
                .FirstOrDefaultAsync(m => m.Id == id);
            if (midia == null)
            {
                return NotFound();
            }

            return View(midia);
        }

        // POST: Midias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var midia = await _context.Midias.FindAsync(id);
            _context.Midias.Remove(midia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MidiaExists(int id)
        {
            return _context.Midias.Any(e => e.Id == id);
        }
    }
}
