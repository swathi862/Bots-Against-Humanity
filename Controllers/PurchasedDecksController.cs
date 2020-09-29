using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CardGame.Data;
using CardGame.Models;

namespace CardGame.Controllers
{
    public class PurchasedDecksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PurchasedDecksController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PurchasedDecks
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.PurchasedDeck.Include(p => p.Deck);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: PurchasedDecks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchasedDeck = await _context.PurchasedDeck
                .Include(p => p.Deck)
                .FirstOrDefaultAsync(m => m.PurchasedDeckId == id);
            if (purchasedDeck == null)
            {
                return NotFound();
            }

            return View(purchasedDeck);
        }

        // GET: PurchasedDecks/Create
        public IActionResult Create()
        {
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name");
            return View();
        }

        // POST: PurchasedDecks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PurchasedDeckId,DeckId,UserId")] PurchasedDeck purchasedDeck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchasedDeck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name", purchasedDeck.DeckId);
            return View(purchasedDeck);
        }

        // GET: PurchasedDecks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchasedDeck = await _context.PurchasedDeck.FindAsync(id);
            if (purchasedDeck == null)
            {
                return NotFound();
            }
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name", purchasedDeck.DeckId);
            return View(purchasedDeck);
        }

        // POST: PurchasedDecks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PurchasedDeckId,DeckId,UserId")] PurchasedDeck purchasedDeck)
        {
            if (id != purchasedDeck.PurchasedDeckId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchasedDeck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchasedDeckExists(purchasedDeck.PurchasedDeckId))
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
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name", purchasedDeck.DeckId);
            return View(purchasedDeck);
        }

        // GET: PurchasedDecks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchasedDeck = await _context.PurchasedDeck
                .Include(p => p.Deck)
                .FirstOrDefaultAsync(m => m.PurchasedDeckId == id);
            if (purchasedDeck == null)
            {
                return NotFound();
            }

            return View(purchasedDeck);
        }

        // POST: PurchasedDecks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchasedDeck = await _context.PurchasedDeck.FindAsync(id);
            _context.PurchasedDeck.Remove(purchasedDeck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchasedDeckExists(int id)
        {
            return _context.PurchasedDeck.Any(e => e.PurchasedDeckId == id);
        }
    }
}
