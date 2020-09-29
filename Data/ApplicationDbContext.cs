using System;
using System.Collections.Generic;
using System.Text;

using CardGame.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CardGame.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ApplicationUser> ApplicationUser { get; set; }
        public DbSet<AnswerCard> AnswerCard { get; set; }
        public DbSet<QuestionCard> QuestionCard { get; set; }
        public DbSet<Deck> Deck { get; set; }
        public DbSet<PurchasedDeck> PurchasedDeck { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Create user
            ApplicationUser user = new ApplicationUser
            {
                FirstName = "Swathi",
                LastName = "Mukkamala",
                UserName = "Swathi86",
                NormalizedUserName = "SWATHI86",
                Email = "swathi@email.com",
                NormalizedEmail = "SWATHI@EMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
                Id = "000000001"
            };
            var passwordHash = new PasswordHasher<ApplicationUser>();
            user.PasswordHash = passwordHash.HashPassword(user, "Abc123@");
            modelBuilder.Entity<ApplicationUser>().HasData(user);

            modelBuilder.Entity<QuestionCard>().HasData(
                new QuestionCard()
                {
                    QuestionCardId = 1,
                    Description = "This is your captain speaking. Fasten your seatbelts and prepare for"
                },
                new QuestionCard()
                {
                    QuestionCardId = 2,
                    Description = "What really brings out the child in me?"
                },
                new QuestionCard()
                {
                    QuestionCardId = 3,
                    Description = "What did The Rock eat for dinner?"
                },
                new QuestionCard()
                {
                    QuestionCardId = 4,
                    Description = "My gym teacher got fired for adding _______ to the obstacle course."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 5,
                    Description = "What did I give up for Lent?"
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 6,
                    Description = "The class field trip was completely ruined by _______."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 7,
                    Description = "This is the prime of my life. I'm young, hot, and full of ___________."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 8,
                    Description = "I learned the hard way that you can't cheer up a grieving friend with ___________."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 9,
                    Description = "I'm not like the rest of you. I'm too rich and busy for _________."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 10,
                    Description = "What are all those chipmunks singing about?"
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 11,
                    Description = "___________: kid-tested, mother-approved"
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 12,
                    Description = "Science will never explain ___________."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 13,
                    Description = "West Virginia runs on __________."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 14,
                    Description = "I've got 99 problems but ___________ ain't one."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 15,
                    Description = "What's that sound?"
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 16,
                    Description = "What's a girl's best friend?"
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 17,
                    Description = "_________. That's how I want to die."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 18,
                    Description = "I'm sorry, Professor, but I couldn't complete my homework because of __________."
                }, 
                new QuestionCard()
                {
                    QuestionCardId = 19,
                    Description = "Sorry I'm late! I was ____________."
                },
                new QuestionCard()
                {
                    QuestionCardId = 20,
                    Description = "Breaking News: ____________."
                },
                new QuestionCard()
                {
                    QuestionCardId = 21,
                    Description = "I'm thinking about getting a lower-back tattoo of _________."
                },
                new QuestionCard()
                {
                    QuestionCardId = 22,
                    Description = "Love is patient. Love is kind. Love is __________."
                },
                new QuestionCard()
                {
                    QuestionCardId = 23,
                    Description = "What ended my last relationship?"
                },
                new QuestionCard()
                {
                    QuestionCardId = 24,
                    Description = "Before I run for president, I must destroy all evidence of my involvement with __________."
                },
                new QuestionCard()
                {
                    QuestionCardId = 25,
                    Description = "____________. Awesome in theory, kind of a mess in practice."
                }
            );

            modelBuilder.Entity<Deck>().HasData(
                new Deck()
                {
                    DeckId = 1,
                    Name = "Starter Deck",
                    Price = 0
                },
                new Deck()
                {
                    DeckId = 2,
                    Name = "Just Office Things",
                    Price = 15
                },
                new Deck()
                {
                    DeckId = 3,
                    Name = "Disney Villains",
                    Price = 45
                },
                new Deck()
                {
                    DeckId = 4,
                    Name = "Illnesses and Ailments",
                    Price = 95
                },
                new Deck()
                {
                    DeckId = 5,
                    Name = "Quintessential Horror Movie Scenes",
                    Price = 155
                }
            );

            modelBuilder.Entity<AnswerCard>().HasData(
                new AnswerCard()
                {
                    AnswerCardId = 1,
                    Description = "Apple Pie",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 2,
                    Description = "Nothing",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 3,
                    Description = "Blueberries",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 4,
                    Description = "Death by bees",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 5,
                    Description = "Me time",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 6,
                    Description = "Neil Patrick Harris",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 7,
                    Description = "Power",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 8,
                    Description = "Active Listening",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 9,
                    Description = "College",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 10,
                    Description = "Moral Ambiguity",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 11,
                    Description = "Buddy, the goat, eating cans",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 12,
                    Description = "Living in a trashcan",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 13,
                    Description = "The miracle of childbirth",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 14,
                    Description = "Frolicking",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 15,
                    Description = "A private island caretaker",
                    PointValue = 1,
                    DeckId = 1
                },
                new AnswerCard()
                {
                    AnswerCardId = 16,
                    Description = "Asking your boss for a raise",
                    PointValue = 2,
                    DeckId = 2
                },
                new AnswerCard()
                {
                    AnswerCardId = 17,
                    Description = "Making the printer work",
                    PointValue = 2,
                    DeckId = 2
                },
                new AnswerCard()
                {
                    AnswerCardId = 18,
                    Description = "Writing up to-do lists",
                    PointValue = 2,
                    DeckId = 2
                },
                new AnswerCard()
                {
                    AnswerCardId = 19,
                    Description = "Finding out your co-worker stole your stapler",
                    PointValue = 2,
                    DeckId = 2
                },
                new AnswerCard()
                {
                    AnswerCardId = 20,
                    Description = "Workplace meetings",
                    PointValue = 2,
                    DeckId = 2
                },
                new AnswerCard()
                {
                    AnswerCardId = 21,
                    Description = "Maleficent",
                    PointValue = 3,
                    DeckId = 3
                },
                new AnswerCard()
                {
                    AnswerCardId = 22,
                    Description = "Cruella de Vil",
                    PointValue = 3,
                    DeckId = 3
                },
                new AnswerCard()
                {
                    AnswerCardId = 23,
                    Description = "Hades",
                    PointValue = 3,
                    DeckId = 3
                },
                new AnswerCard()
                {
                    AnswerCardId = 24,
                    Description = "Dr.Facilier",
                    PointValue = 3,
                    DeckId = 3
                },
                new AnswerCard()
                {
                    AnswerCardId = 25,
                    Description = "The Evil Queen",
                    PointValue = 3,
                    DeckId = 3
                },
                new AnswerCard()
                {
                    AnswerCardId = 26,
                    Description = "An outbreak of smallpox",
                    PointValue = 4,
                    DeckId = 4
                },
                new AnswerCard()
                {
                    AnswerCardId = 27,
                    Description = "Famine",
                    PointValue = 4,
                    DeckId = 4
                },
                new AnswerCard()
                {
                    AnswerCardId = 28,
                    Description = "Dysentery",
                    PointValue = 4,
                    DeckId = 4
                },
                new AnswerCard()
                {
                    AnswerCardId = 29,
                    Description = "The Bubonic Plague",
                    PointValue = 4,
                    DeckId = 4
                },
                new AnswerCard()
                {
                    AnswerCardId = 30,
                    Description = "The 'Rona",
                    PointValue = 4,
                    DeckId = 4
                },
                new AnswerCard()
                {
                    AnswerCardId = 31,
                    Description = "Ripping into a man's chest and pulling out his still-beating heart",
                    PointValue = 5,
                    DeckId = 5
                },
                new AnswerCard()
                {
                    AnswerCardId = 32,
                    Description = "Entering a breakout room to find Beatrice patiently waiting for you",
                    PointValue = 5,
                    DeckId = 5
                },
                new AnswerCard()
                {
                    AnswerCardId = 33,
                    Description = "Having a demon-possesed being crawl toward you down a flight of stairs",
                    PointValue = 5,
                    DeckId = 5
                },
                new AnswerCard()
                {
                    AnswerCardId = 34,
                    Description = "Sacrificing your soul to a witch in exchange for their blood",
                    PointValue = 5,
                    DeckId = 5
                },
                new AnswerCard()
                {
                    AnswerCardId = 35,
                    Description = "Performing a seance during the witching hour",
                    PointValue = 5,
                    DeckId = 5
                }
            );

            //modelBuilder.Entity<AnswerCard>().HasData(
            //    new PurchasedDeck()
            //    {
            //        PurchasedDeckId = 1,
            //        DeckId = 1,
            //        UserId = 1
            //    }
            //);


        }
    }
}
