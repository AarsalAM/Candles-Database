using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Candles_Database.Data;
using Candles_Database.Models;

namespace Candles_Database.Controllers
{
    public class CandlesController : Controller
    {
        private readonly Candles_DatabaseContext _context;

        public CandlesController(Candles_DatabaseContext context)
        {
            _context = context;
        }

        // GET: Candles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Candles.ToListAsync());
        }

        // GET: Candles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candles = await _context.Candles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candles == null)
            {
                return NotFound();
            }

            return View(candles);
        }

        // GET: Candles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Candles/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,canType,Colour,Price,Rating")] Candles candles)
        {
            if (ModelState.IsValid)
            {
                _context.Add(candles);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(candles);
        }

        // GET: Candles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candles = await _context.Candles.FindAsync(id);
            if (candles == null)
            {
                return NotFound();
            }
            return View(candles);
        }

        // POST: Candles/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,canType,Colour,Price,Rating")] Candles candles)
        {
            if (id != candles.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(candles);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CandlesExists(candles.Id))
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
            return View(candles);
        }

        // GET: Candles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var candles = await _context.Candles
                .FirstOrDefaultAsync(m => m.Id == id);
            if (candles == null)
            {
                return NotFound();
            }

            return View(candles);
        }

        // POST: Candles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var candles = await _context.Candles.FindAsync(id);
            _context.Candles.Remove(candles);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CandlesExists(int id)
        {
            return _context.Candles.Any(e => e.Id == id);
        }
    }
}
