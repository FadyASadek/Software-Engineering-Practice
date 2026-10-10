using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Count_of_positives__sum_of_negatives
    {
        public static int[] CountPositivesSumNegatives(int[] input) => (input is null || input.Length == 0) ? new int[] {} : new int[] {input.Where(a=>a>0).Count(),input.Where(a=>a<0).Sum()};
    }
}
