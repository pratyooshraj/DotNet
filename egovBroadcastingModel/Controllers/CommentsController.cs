﻿using System;
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
    public class CommentsController : Controller
    {
        private readonly AppDbContext _context;

        public CommentsController(AppDbContext context)
        {
            _context = context;
        }

        [Authorize(Roles ="admin")]
        // GET: Comments
        public async Task<IActionResult> Index()
        {
            var appDbContext = _context.Comments.Include(c => c.DisasterNotice);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Comments/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.DisasterNotice)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // GET: Comments/Create
        public IActionResult Create()
        {
            ViewData["DisasterNoticeId"] = new SelectList(_context.DisasterNotices, "Id", "Description");
            return View();
        }

        // POST: Comments/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Content,Username,CommentDateTime,DisasterNoticeId")] Comment comment)
        {
            //if (ModelState.IsValid)
            //{
                _context.Add(comment);
               
            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "DisasterNotices", new { id = comment.DisasterNoticeId });

            //   return RedirectToAction(nameof(Index));
            // }
            // ViewData["DisasterNoticeId"] = new SelectList(_context.DisasterNotices, "Id", "Description", comment.DisasterNoticeId);
            // return View(comment);
        }

        // GET: Comments/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments.FindAsync(id);
            if (comment == null)
            {
                return NotFound();
            }
            ViewData["DisasterNoticeId"] = new SelectList(_context.DisasterNotices, "Id", "Description", comment.DisasterNoticeId);
            return View(comment);
        }

        // POST: Comments/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Content,Username,CommentDateTime,DisasterNoticeId")] Comment comment)
        {
            if (id != comment.Id)
            {
                return NotFound();
            }

           // if (ModelState.IsValid)
           // {
                try
                {
                    _context.Update(comment);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CommentExists(comment.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            return RedirectToAction("Details", "DisasterNotices", new { id = comment.DisasterNoticeId });

//            return RedirectToAction(nameof(Index));
           // }
           // ViewData["DisasterNoticeId"] = new SelectList(_context.DisasterNotices, "Id", "Description", comment.DisasterNoticeId);
           // return View(comment);
        }

        // GET: Comments/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var comment = await _context.Comments
                .Include(c => c.DisasterNotice)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (comment == null)
            {
                return NotFound();
            }

            return View(comment);
        }

        // POST: Comments/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var comment = await _context.Comments.FindAsync(id);
            if (comment != null)
            {
                _context.Comments.Remove(comment);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction("Details", "DisasterNotices", new { id = comment.DisasterNoticeId });

//            return RedirectToAction(nameof(Index));
        }

        private bool CommentExists(int id)
        {
            return _context.Comments.Any(e => e.Id == id);
        }
    }
}
