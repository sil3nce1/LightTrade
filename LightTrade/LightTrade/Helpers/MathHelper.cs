using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.Helpers
{
    public static class MathHelper
    {
        public static double CalculatePercentage(int percentage, double total)
        {
            return percentage * total / 100;
        }
    }
}
