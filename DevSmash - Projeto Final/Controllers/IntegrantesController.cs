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
using Microsoft.AspNetCore.Authorization;

namespace DevSmash___Projeto_Final.Controllers
{
    [Authorize]
    public class IntegrantesController : Controller
    {
        private readonly SiteContext _context;

        public IntegrantesController(SiteContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Integrantes.ToListAsync());
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var integrante = await _context.Integrantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integrante == null)
            {
                return NotFound();
            }

            return View(integrante);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Funcao,RedeSocial,Sobre")] Integrante integrante)
        {
            if (ModelState.IsValid)
            {
                _context.Add(integrante);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(integrante);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var integrante = await _context.Integrantes.FindAsync(id);
            if (integrante == null)
            {
                return NotFound();
            }
            return View(integrante);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Funcao,RedeSocial,Sobre")] Integrante integrante)
        {
            if (id != integrante.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(integrante);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IntegranteExists(integrante.Id))
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
            return View(integrante);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var integrante = await _context.Integrantes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (integrante == null)
            {
                return NotFound();
            }

            return View(integrante);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var integrante = await _context.Integrantes.FindAsync(id);
            _context.Integrantes.Remove(integrante);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IntegranteExists(int id)
        {
            return _context.Integrantes.Any(e => e.Id == id);
        }
    }
}
