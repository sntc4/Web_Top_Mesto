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
    public class LoungesController : Controller
    {
        private readonly Top_Mesto_WebContext _context;

        public LoungesController(Top_Mesto_WebContext context)
        {
            _context = context;
        }

        // GET: Lounges
        public async Task<IActionResult> Index()
        {
            return View(await _context.Lounge.ToListAsync());
        }

        // GET: Lounges/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lounge = await _context.Lounge
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lounge == null)
            {
                return NotFound();
            }

            return View(lounge);
        }

        // GET: Lounges/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lounges/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Title,Address,SrChek,Lamp,Rating")] Lounge lounge)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lounge);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lounge);
        }

        // GET: Lounges/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lounge = await _context.Lounge.FindAsync(id);
            if (lounge == null)
            {
                return NotFound();
            }
            return View(lounge);
        }

        // POST: Lounges/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Title,Address,SrChek,Lamp,Rating")] Lounge lounge)
        {
            if (id != lounge.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lounge);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LoungeExists(lounge.ID))
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
            return View(lounge);
        }

        // GET: Lounges/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lounge = await _context.Lounge
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lounge == null)
            {
                return NotFound();
            }

            return View(lounge);
        }

        // POST: Lounges/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lounge = await _context.Lounge.FindAsync(id);
            _context.Lounge.Remove(lounge);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LoungeExists(int id)
        {
            return _context.Lounge.Any(e => e.ID == id);
        }
    }
}
