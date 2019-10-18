using System;
using System.Collections.Generic;
using System.Text;

namespace CritCalc
{
    public static class DamageCalcHelper
    {
        public static double CalculateCriticalStrike(int finalCrit, int agiFinal)
        {
            return finalCrit * ((Math.E * 1.1) / Math.Log(agiFinal + 12));
        }
    }
}
