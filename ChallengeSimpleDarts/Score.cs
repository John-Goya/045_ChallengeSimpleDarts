using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Score
    {
        public static void DartScore(Player player, Dart darts) // running tally/calculate total score
        {
            int runningScore = 0;
            if (darts.IsTriple) runningScore = darts.Score * 3;
            else if (darts.IsDouble) runningScore = darts.Score * 2;
            else if (darts.IsOuterBullseye) runningScore = 25;
            else if (darts.IsInnerBullseye) runningScore = 50;

            player.Score += runningScore;
        }
    }
}