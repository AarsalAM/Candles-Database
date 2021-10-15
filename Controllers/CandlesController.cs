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
        public async Task<IActionResult> Index(string candleType, string searchString)     //I update the index to add the ability to search through the database.
        {
            IQueryable<string> typeQuery = from m in _context.Candles
                                            orderby m.canType
                                            select m.canType;

            var candle = from m in _context.Candles
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                candle = candle.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(candleType))              //Add the ability to search by the candle type as well
            {
                candle = candle.Where(x => x.canType == candleType);
            }

            var candleTypeVM = new CandleTypeViewModel
            {
                Types = new SelectList(await typeQuery.Distinct().ToListAsync()),
                Candle = await candle.ToListAsync()
            };

            return View(candleTypeVM);
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
        public async Task<IActionResult> Create([Bind("Id,Name,canType,Colour,Price,Rating,UserRating")] Candles candles)
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
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,canType,Colour,Price,UserRating")] Candles candles)
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
