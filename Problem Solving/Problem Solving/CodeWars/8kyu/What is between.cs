using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class What_is_between
    {
        public static int[] Between(int a, int b)
        {
            return Enumerable.Range(a, b - a + 1).ToArray();

        }
    }
}
