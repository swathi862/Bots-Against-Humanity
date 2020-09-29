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
            return View();
        }

        //private List for questions
        private List<QuestionCard> playingQuestionCards = new List<QuestionCard>();

        //private List for answers
        private List<AnswerCard> playingAnswerCards = new List<AnswerCard>();

        public async Task<IActionResult> PlayGame()
        {
            var user = await GetCurrentUserAsync();

            //if (user.PurchasedDecks.Count == 0)
            //{
            //make deck 1 the default deck
            //};


            //Access(query) deck 1, include answer cards
            var allAnswerCards = _context.AnswerCard.Where(d => d.DeckId == 1).OrderBy(r => Guid.NewGuid()).ToListAsync();

            //Pull out 15 *random* answer cards (get all cards from deck)- reassign to private list
            playingAnswerCards = await allAnswerCards;

            //Access question cards
            var getQuestionCards = _context.QuestionCard.OrderBy(r => Guid.NewGuid()).Take(5).ToListAsync();

            //Pull out 5 random question cards (have to do the random here)- reassign to private list
            playingQuestionCards = await getQuestionCards;

            //Pull out 3 Answer cards (Remove the cards from list after they're pulled- LINQ method)

            PlayingRoundCards round = new PlayingRoundCards();
            round.playerOneCard = playingAnswerCards[0];
            round.playerTwoCard = playingAnswerCards[1];
            round.playerThreeCard = playingAnswerCards[2];
            round.roundQuestionCard = playingQuestionCards[0];


            return View(round);
        }
    }
}
