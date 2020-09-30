using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CardGame.Models;

namespace CardGame
{
    public abstract class GameData
    {
        public static List<QuestionCard> playingQuestionCards = new List<QuestionCard>();

        public static List<AnswerCard> playingAnswerCards = new List<AnswerCard>();
        public static int gameTotal { get; set; }
        public static int roundCounter { get; set; }

        //public int Total()
        //{
        //    return gameTotal;
        //}
    }
}
