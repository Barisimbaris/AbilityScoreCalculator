using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbilityScoreCalculator
{
     class AbilityScoreCalculator
    {
        public int rollResult = 14;
        public double DvideBy = 1.75;
        public int Amount = 2;
        public int Minimum = 3;
        public int score;
        
            public void CalculateAbilityScore()
            {
                double dvided = rollResult * DvideBy;
                int added = Convert.ToInt32(dvided) + Amount;
                if (added < Minimum)
                {
                    score = Minimum;
                }
                else
                {
                    score = added;
                }
            }
        
    }
}
