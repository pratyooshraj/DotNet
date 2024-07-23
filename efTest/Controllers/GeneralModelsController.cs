using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using efTest.Data;
using efTest.Models;

namespace efTest.Controllers
{
    public class GeneralModelsController : Controller
    {
        private readonly AppDbContext _context;

        public GeneralModelsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: GeneralModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.GenTable.ToListAsync());
        }

        // GET: GeneralModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalModel = await _context.GenTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalModel == null)
            {
                return NotFound();
            }

            return View(generalModel);
        }

        // GET: GeneralModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: GeneralModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description")] GeneralModel generalModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(generalModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(generalModel);
        }

        // GET: GeneralModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalModel = await _context.GenTable.FindAsync(id);
            if (generalModel == null)
            {
                return NotFound();
            }
            return View(generalModel);
        }

        // POST: GeneralModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description")] GeneralModel generalModel)
        {
            if (id != generalModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(generalModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GeneralModelExists(generalModel.Id))
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
            return View(generalModel);
        }

        // GET: GeneralModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var generalModel = await _context.GenTable
                .FirstOrDefaultAsync(m => m.Id == id);
            if (generalModel == null)
            {
                return NotFound();
            }

            return View(generalModel);
        }

        // POST: GeneralModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var generalModel = await _context.GenTable.FindAsync(id);
            if (generalModel != null)
            {
                _context.GenTable.Remove(generalModel);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GeneralModelExists(int id)
        {
            return _context.GenTable.Any(e => e.Id == id);
        }
    }
}
