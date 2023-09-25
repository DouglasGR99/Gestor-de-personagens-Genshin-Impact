using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestorGenshinCharacters.Data;
using GestorGenshinCharacters.Models;

namespace GestorGenshinCharacters.Controllers
{
    public class PersonagemModelsController : Controller
    {
        private readonly BancoContext _context;

        public PersonagemModelsController(BancoContext context)
        {
            _context = context;
        }

        // GET: PersonagemModels
        public async Task<IActionResult> Index()
        {
              return _context.Personagem != null ? 
                          View(await _context.Personagem.ToListAsync()) :
                          Problem("Entity set 'BancoContext.Personagem'  is null.");
        }

        // GET: PersonagemModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Personagem == null)
            {
                return NotFound();
            }

            var personagemModel = await _context.Personagem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personagemModel == null)
            {
                return NotFound();
            }

            return View(personagemModel);
        }

        // GET: PersonagemModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PersonagemModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nivel,Nome,Classe,Constelacao,NvlGol,NvlHab,NvlUlt,Visao")] PersonagemModel personagemModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(personagemModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(personagemModel);
        }

        // GET: PersonagemModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Personagem == null)
            {
                return NotFound();
            }

            var personagemModel = await _context.Personagem.FindAsync(id);
            if (personagemModel == null)
            {
                return NotFound();
            }
            return View(personagemModel);
        }

        // POST: PersonagemModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nivel,Nome,Classe,Constelacao,NvlGol,NvlHab,NvlUlt,Visao")] PersonagemModel personagemModel)
        {
            if (id != personagemModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(personagemModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonagemModelExists(personagemModel.Id))
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
            return View(personagemModel);
        }

        // GET: PersonagemModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Personagem == null)
            {
                return NotFound();
            }

            var personagemModel = await _context.Personagem
                .FirstOrDefaultAsync(m => m.Id == id);
            if (personagemModel == null)
            {
                return NotFound();
            }

            return View(personagemModel);
        }

        // POST: PersonagemModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Personagem == null)
            {
                return Problem("Entity set 'BancoContext.Personagem'  is null.");
            }
            var personagemModel = await _context.Personagem.FindAsync(id);
            if (personagemModel != null)
            {
                _context.Personagem.Remove(personagemModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonagemModelExists(int id)
        {
          return (_context.Personagem?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
