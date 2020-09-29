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
    public class QuestionCardsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public QuestionCardsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: QuestionCards
        public async Task<IActionResult> Index()
        {
            return View(await _context.QuestionCard.ToListAsync());
        }

        // GET: QuestionCards/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionCard = await _context.QuestionCard
                .FirstOrDefaultAsync(m => m.QuestionCardId == id);
            if (questionCard == null)
            {
                return NotFound();
            }

            return View(questionCard);
        }

        // GET: QuestionCards/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: QuestionCards/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("QuestionCardId,Description")] QuestionCard questionCard)
        {
            if (ModelState.IsValid)
            {
                _context.Add(questionCard);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(questionCard);
        }

        // GET: QuestionCards/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionCard = await _context.QuestionCard.FindAsync(id);
            if (questionCard == null)
            {
                return NotFound();
            }
            return View(questionCard);
        }

        // POST: QuestionCards/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("QuestionCardId,Description")] QuestionCard questionCard)
        {
            if (id != questionCard.QuestionCardId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(questionCard);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!QuestionCardExists(questionCard.QuestionCardId))
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
            return View(questionCard);
        }

        // GET: QuestionCards/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var questionCard = await _context.QuestionCard
                .FirstOrDefaultAsync(m => m.QuestionCardId == id);
            if (questionCard == null)
            {
                return NotFound();
            }

            return View(questionCard);
        }

        // POST: QuestionCards/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var questionCard = await _context.QuestionCard.FindAsync(id);
            _context.QuestionCard.Remove(questionCard);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool QuestionCardExists(int id)
        {
            return _context.QuestionCard.Any(e => e.QuestionCardId == id);
        }
    }
}
