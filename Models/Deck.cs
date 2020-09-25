using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame.Models
{
    public class Deck
    {
        [Key]
        public int DeckId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        public List<AnswerCard> AnswerCards { get; set; }

        public List<PurchasedDeck> PurchasedDeck { get; set; }
    }
}
