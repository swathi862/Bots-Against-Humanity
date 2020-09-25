using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame.Models
{
    public class AnswerCard
    {
        [Key]
        public int AnswerCardId { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public int PointValue { get; set; }

        [Required]
        public int DeckId { get; set; }

        public Deck Deck { get; set; }
    }
}
