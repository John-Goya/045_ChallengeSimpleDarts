using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Darts
{
    public class Dart
    {
        public int Score { get; set; }//intitalize "Score"
        public bool IsDouble { get; set; }//yes or no is dart in double ring? 5% (1)
        public bool IsTriple { get; set; }//yes or no is dart in triple ring? 5% (2)
        public bool IsOuterBullseye { get; set; } //score = 0 outer bullseye
        public bool IsInnerBullseye { get; set; } //score = 0 and 5% (2)

        private Random _randomthrowresult;
        public Dart(Random random)
        {
            _randomthrowresult = random; //to generate random number for "_randomthrowresult"
        }
        public void Throw()
        {
            Score = _randomthrowresult.Next(0, 21);//to generate random "Score" of dart throw within 20 areas(21 not incusive)
            int multiplier = _randomthrowresult.Next(0, 101);//generate percentage of double or triple ring
            if (multiplier > 95) IsDouble = true;//5% for double ring
            if (90 < multiplier && multiplier <= 95) IsTriple = true;//5% for triple ring
            if (Score == 0) IsOuterBullseye = true;//check for Outer Bullseye
            else if (IsOuterBullseye == true && IsDouble == true) IsInnerBullseye = true;//check for Inner Bullseye
        }
    }
}