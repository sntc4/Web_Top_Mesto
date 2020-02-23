using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Top_Mesto_Web.Models;

namespace Top_Mesto_Web.Controllers
{
    public class KultsController : Controller
    {
        private readonly Top_Mesto_WebContext _context;

        public KultsController(Top_Mesto_WebContext context)
        {
            _context = context;
        }

        // GET: Kults
        public async Task<IActionResult> Index()
        {
            return View(await _context.Kults.ToListAsync());
        }

        // GET: Kults/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kults = await _context.Kults
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kults == null)
            {
                return NotFound();
            }

            return View(kults);
        }

        // GET: Kults/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Kults/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Address,Classif,Rating")] Kults kults)
        {
            if (ModelState.IsValid)
            {
                _context.Add(kults);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(kults);
        }

        // GET: Kults/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kults = await _context.Kults.FindAsync(id);
            if (kults == null)
            {
                return NotFound();
            }
            return View(kults);
        }

        // POST: Kults/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Address,Classif,Rating")] Kults kults)
        {
            if (id != kults.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(kults);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!KultsExists(kults.ID))
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
            return View(kults);
        }

        // GET: Kults/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var kults = await _context.Kults
                .FirstOrDefaultAsync(m => m.ID == id);
            if (kults == null)
            {
                return NotFound();
            }

            return View(kults);
        }

        // POST: Kults/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var kults = await _context.Kults.FindAsync(id);
            _context.Kults.Remove(kults);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool KultsExists(int id)
        {
            return _context.Kults.Any(e => e.ID == id);
        }
    }
}
