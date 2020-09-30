using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame.Models.ViewModels
{
    public class PlayingRoundCards
    {
        public List<AnswerCard> roundAnswerCards = new List<AnswerCard>();

        public QuestionCard roundQuestionCard { get; set; }
    }
}
