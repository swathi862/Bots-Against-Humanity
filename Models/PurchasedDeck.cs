using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame.Models
{
    public class PurchasedDeck
    {
        [Key]
        public int PurchasedDeckId { get; set; }

        [Required]
        public int DeckId { get; set; }

        [Required]
        public int UserId { get; set; }

        public ApplicationUser User { get; set; }

        public Deck Deck { get; set; }
    }
}
