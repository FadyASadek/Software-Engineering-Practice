using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Count_by_X
    {
        public static int[] CountBy(int x, int n)
        {
            int[] z = new int[n+1];
            for (int i = 1; i <= n; i++)
            {
                z[i] = i * x;
            } 
            return z;
        }
    }
}
