using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CardGame.Data;
using CardGame.Models;
using Microsoft.AspNetCore.Identity;

namespace CardGame.Controllers
{
    public class DecksController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public DecksController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: Decks
        public async Task<IActionResult> Index()
        {
            var user = await GetCurrentUserAsync();

            List<Deck> allDecks = await _context.Deck.Include(d => d.PurchasedDeck).ThenInclude(pd => pd.User).ToListAsync();

            List<Deck> filteredDecks = allDecks.Where(d => d.DeckId != 1 && !d.PurchasedDeck.Any(c => c.UserId == user.Id)).ToList();

            ViewBag.totalScore = user.Score;

            return View(filteredDecks);
        }

        // GET: Decks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deck = await _context.Deck
                .FirstOrDefaultAsync(m => m.DeckId == id);
            if (deck == null)
            {
                return NotFound();
            }

            return View(deck);
        }

        // GET: Decks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Decks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("DeckId,Name,Price")] Deck deck)
        {
            if (ModelState.IsValid)
            {
                _context.Add(deck);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(deck);
        }

        // GET: Decks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deck = await _context.Deck.FindAsync(id);
            if (deck == null)
            {
                return NotFound();
            }
            return View(deck);
        }

        // POST: Decks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("DeckId,Name,Price")] Deck deck)
        {
            if (id != deck.DeckId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(deck);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DeckExists(deck.DeckId))
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
            return View(deck);
        }

        // GET: Decks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var deck = await _context.Deck
                .FirstOrDefaultAsync(m => m.DeckId == id);
            if (deck == null)
            {
                return NotFound();
            }

            return View(deck);
        }

        // POST: Decks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var deck = await _context.Deck.FindAsync(id);
            _context.Deck.Remove(deck);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DeckExists(int id)
        {
            return _context.Deck.Any(e => e.DeckId == id);
        }

        public async Task<IActionResult> PurchaseDeck(int deckValue, int deckId)
        {
            var user = await GetCurrentUserAsync();

            if (deckValue <= user.Score)
            {
                user.Score = user.Score - deckValue;
                _context.Update(user);
                await _context.SaveChangesAsync();

                PurchasedDeck purchasedDeck = new PurchasedDeck
                {
                    UserId = user.Id,
                    DeckId = deckId
                };

                if (ModelState.IsValid)
                {
                    _context.Add(purchasedDeck);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            else
            {
                ViewBag["message"] = "You don't have enough points to purchase this deck. Go collect more points.";
            }

            ViewBag["totalScore"] = user.Score;

            return RedirectToAction("Index");
        }
    }
}
