using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Sum_of_positive
    {
        public static int PositiveSum(int[] arr) => arr.Where(a=> a > 0).Sum();
    }
}
