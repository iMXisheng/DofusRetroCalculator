using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CritCalc
{


    public static class DropRateCalc
    {
        public static double CalculateDropChance(double characterProspectingInt, double dropProbability)
        {
            return (dropProbability * (1+(characterProspectingInt/100)));
        }
    }
}
