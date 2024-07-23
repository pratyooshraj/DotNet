using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using egovBroadcastingModel.Data;
using egovBroadcastingModel.Models;
using Microsoft.AspNetCore.Authorization;

namespace egovBroadcastingModel.Controllers
{
    public class DisasterNoticesController : Controller
    {
        private readonly AppDbContext _context;

        public DisasterNoticesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: DisasterNotices
        
        public async Task<IActionResult> Index()
        {
            return View(await _context.DisasterNotices.ToListAsync());
        }

        // GET: DisasterNotices/Details/5
        [Authorize(Roles = "admin,client")]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //var disasterNotice = await _context.DisasterNotices
            //    .FirstOrDefaultAsync(m => m.Id == id);
            var disasterNotice = await _context.DisasterNotices
                .Include(d => d.Comments) // Include related comments
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disasterNotice == null)
            {
                return NotFound();
            }

            return View(disasterNotice);
        }

        // GET: DisasterNotices/Create
        [Authorize(Roles = "admin")]
        public IActionResult Create()
        {
            ViewBag.Severity = new SelectList(Enum.GetValues(typeof(Severity)));
            return View();
        }

        // POST: DisasterNotices/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DisasterType,Title,Description,EventDateTime,Severity,Location,Source,NoticeDateTime,Remarks")] DisasterNotice disasterNotice)
        {
        //    if (ModelState.IsValid)
         //   {
                _context.Add(disasterNotice);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
      //  }
            
        //ViewBag.Severity = new SelectList(Enum.GetValues(typeof(Severity)));
           // return View(disasterNotice);
    }

        // GET: DisasterNotices/Edit/5
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterNotice = await _context.DisasterNotices.FindAsync(id);
            if (disasterNotice == null)
            {
                return NotFound();
            }
            ViewBag.Severity = new SelectList(Enum.GetValues(typeof(Severity)));

            return View(disasterNotice);
        }

        // POST: DisasterNotices/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Roles = "admin")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DisasterType,Title,Description,EventDateTime,Severity,Location,Source,NoticeDateTime,Remarks")] DisasterNotice disasterNotice)
        {
            if (id != disasterNotice.Id)
            {
                return NotFound();
            }

           // if (ModelState.IsValid)
            //{
                try
                {
                    _context.Update(disasterNotice);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DisasterNoticeExists(disasterNotice.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
           // }
          //  ViewBag.Severity = new SelectList(Enum.GetValues(typeof(Severity)));

            //return View(disasterNotice);
        }

        // GET: DisasterNotices/Delete/5
        [Authorize(Roles ="admin")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var disasterNotice = await _context.DisasterNotices
                .FirstOrDefaultAsync(m => m.Id == id);
            if (disasterNotice == null)
            {
                return NotFound();
            }

            return View(disasterNotice);
        }

        // POST: DisasterNotices/Delete/5
        [Authorize(Roles = "admin")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var disasterNotice = await _context.DisasterNotices.FindAsync(id);
            if (disasterNotice != null)
            {   
                _context.DisasterNotices.Remove(disasterNotice);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        //[Authorize(Roles = "admin, client")]
        public IActionResult Filter()
        {
            // Populate the dropdown with distinct disaster types
            var disasterTypes = _context.DisasterNotices
        .Select(d => d.DisasterType)
        .Distinct()
        .ToList();
            
            ViewBag.DisasterTypes = new SelectList(disasterTypes);
            return View();
        }

        [HttpPost]
        public IActionResult Filter(string disasterType)
        {
            //Console.WriteLine($"Received disasterType: {disasterType}");
            var disasterTypes = _context.DisasterNotices
                .Select(d => d.DisasterType)
                .Distinct()
                .ToList();

            ViewBag.DisasterTypes = new SelectList(disasterTypes);

            //if (string.IsNullOrEmpty(disasterType))
            //{
            //    return View(_context.DisasterNotices.ToList());
            //}

            //var trimmedDisasterType = disasterType?.Trim();
            //var disasters = _context.DisasterNotices
            //    .Where(d => d.DisasterType == trimmedDisasterType)
            //    .ToList();

            var disasters = _context.DisasterNotices
         .Where(d => d.DisasterType == disasterType)
         .ToList();
            //Console.WriteLine($"Number of disasters found: {disasters.Count}");
            return View(disasters);
        }

        private bool DisasterNoticeExists(int id)
        {
            return _context.DisasterNotices.Any(e => e.Id == id);
        }
    }
}
