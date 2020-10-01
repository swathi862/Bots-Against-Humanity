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
using CardGame.Models.ViewModels;

namespace CardGame.Controllers
{

    public class AnswerCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        private readonly UserManager<ApplicationUser> _userManager;

        private Task<ApplicationUser> GetCurrentUserAsync() => _userManager.GetUserAsync(HttpContext.User);

        public AnswerCardsController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        // GET: AnswerCards
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.AnswerCard.Include(a => a.Deck);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: AnswerCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerCard = await _context.AnswerCard
                .Include(a => a.Deck)
                .FirstOrDefaultAsync(m => m.AnswerCardId == id);
            if (answerCard == null)
            {
                return NotFound();
            }

            return View(answerCard);
        }

        // GET: AnswerCards/Create
        public IActionResult Create()
        {
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name");
            return View();
        }

        // POST: AnswerCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AnswerCardId,Description,PointValue,DeckId")] AnswerCard answerCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(answerCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name", answerCard.DeckId);
            return View(answerCard);
        }

        // GET: AnswerCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerCard = await _context.AnswerCard.FindAsync(id);
            if (answerCard == null)
            {
                return NotFound();
            }
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name", answerCard.DeckId);
            return View(answerCard);
        }

        // POST: AnswerCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AnswerCardId,Description,PointValue,DeckId")] AnswerCard answerCard)
        {
            if (id != answerCard.AnswerCardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(answerCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnswerCardExists(answerCard.AnswerCardId))
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
            ViewData["DeckId"] = new SelectList(_context.Deck, "DeckId", "Name", answerCard.DeckId);
            return View(answerCard);
        }

        // GET: AnswerCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var answerCard = await _context.AnswerCard
                .Include(a => a.Deck)
                .FirstOrDefaultAsync(m => m.AnswerCardId == id);
            if (answerCard == null)
            {
                return NotFound();
            }

            return View(answerCard);
        }

        // POST: AnswerCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var answerCard = await _context.AnswerCard.FindAsync(id);
            _context.AnswerCard.Remove(answerCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnswerCardExists(int id)
        {
            return _context.AnswerCard.Any(e => e.AnswerCardId == id);
        }

        public IActionResult LoadGame()
        {
            GameData.roundCounter = 0;
            GameData.gameTotal = 0;
            return View();
        }

        public async Task<IActionResult> PlayGame()
        {
            var user = await GetCurrentUserAsync();

            //if (user.PurchasedDecks.Count == 0)
            //{
            //make deck 1 the default deck
            //};

            if (GameData.roundCounter == 0)
            {
                var allAnswerCards = _context.AnswerCard.Where(d => d.DeckId == 1).OrderBy(r => Guid.NewGuid()).ToListAsync();

                GameData.playingAnswerCards = await allAnswerCards;

                var getQuestionCards = _context.QuestionCard.OrderBy(r => Guid.NewGuid()).Take(5).ToListAsync();

                GameData.playingQuestionCards = await getQuestionCards;
            }

            PlayingRoundCards round = new PlayingRoundCards();

            if (GameData.roundCounter < 5)
            {
                round.roundAnswerCards = GameData.playingAnswerCards.Take(3).ToList();
                GameData.playingAnswerCards.RemoveRange(0, 3);
                round.roundQuestionCard = GameData.playingQuestionCards[0];
                GameData.playingQuestionCards.Remove(round.roundQuestionCard);

                return View(round);
            }

            else
            {
                user.Score += GameData.gameTotal;
                _context.Update(user);
                await _context.SaveChangesAsync();

                return RedirectToAction("EndOfGame");
            }

            
        }

        public async Task<IActionResult> PlayNextRound(int cardPointvalue)
        {
            GameData.gameTotal += cardPointvalue;

            GameData.roundCounter ++;

            return RedirectToAction("PlayGame");
        }

        public IActionResult EndOfGame()
        {
            ViewData["gameTotal"] = GameData.gameTotal;
            return View();
        }
    }
}
