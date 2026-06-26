using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem_Solving.CodeWars._8kyu
{
    public static class How_good_are_you_really
    {
        public static bool BetterThanAverage(int[] classPoints, int yourPoints) => yourPoints >= classPoints.Average();
    }
}
