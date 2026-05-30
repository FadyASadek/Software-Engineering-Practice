using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Reversed_sequence
    {
        public static int[] ReverseSeq(int n)
        {
            int[] ints = new int[n];
            for (int i = 0; i < 5; i++)
            {
                ints[i] = n - i;
            }
            return ints;
        }
    }
}
