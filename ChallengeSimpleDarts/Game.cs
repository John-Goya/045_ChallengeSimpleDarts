using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _player1;
        private Player _player2;

        private Random _random;

        public Game(string namePlayer1, string namePlayer2)
        {
            _player1 = new Player();
            _player1.Name = namePlayer1;

            _player2 = new Player();
            _player2.Name = namePlayer2;

            _random = new Random();
        }
        public string Play()// check if either players' score is under 300 to continue rounds.
        {
            while (_player1.Score <300 && _player2.Score < 300)
            {
                playRound(_player1);
                playRound(_player2);
            }
            return displayResults();
        }

        private string displayResults()//output results
        {
            string result = String.Format("{0}: {1}<br/>{2}: {3}<br/>",
                _player1.Name,
                _player1.Score,
                _player2.Name,
                _player2.Score);

            return result += "Winner: " +
                (_player1.Score > _player2.Score ? _player1.Name : _player2.Name);
        }

        private void playRound(Player player)//count number of rounds play for 3 rounds or until 300
        {
            for (int i = 0; i < 3; i++)
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.DartScore(player, dart);
            }
        }
    }
}