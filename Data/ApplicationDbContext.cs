using System;
using System.Collections.Generic;
using System.Text;

using CardGame.Models;

using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CardGame.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<AnswerCard> AnswerCard { get; set; }
        public DbSet<QuestionCard> QuestionCard { get; set; }
        public DbSet<Deck> Deck { get; set; }
        public DbSet<PurchasedDeck> PurchasedDeck { get; set; }

    }
}
