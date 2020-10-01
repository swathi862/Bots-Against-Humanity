using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardGame.Data;
using CardGame.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace CardGame.ViewComponents
{
    public class ScoreCountViewModel
    {
        public int ScoreCount { get; set; } = 0;
    }
    public class ScoreCountViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public ScoreCountViewComponent(ApplicationDbContext c, UserManager<ApplicationUser> userManager)
        {
            _context = c;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Get the current, authenticated user
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);

            // Instantiate view model
            ScoreCountViewModel model = new ScoreCountViewModel();

            // If there is an open order, query appropriate values
            model.ScoreCount = user.Score;

            // Render template bound to OrderCountViewModel
            return View(model);
        }
    }
}
