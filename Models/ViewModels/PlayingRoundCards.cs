using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CardGame.Models.ViewModels
{
    public class PlayingRoundCards
    {
        public AnswerCard playerOneCard { get; set; }
        public AnswerCard playerTwoCard { get; set; }
        public AnswerCard playerThreeCard { get; set; }

        public QuestionCard roundQuestionCard { get; set; }
    }
}
