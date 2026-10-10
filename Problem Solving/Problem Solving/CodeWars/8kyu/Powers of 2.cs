using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Powers_of_2
    {
        public static BigInteger[] PowersOfTwo(int n)
        {
            BigInteger[] newarr = new BigInteger[n + 1];
            newarr[0] = 1;
            for (int i = 1; i < n+1; i++)
            {
                newarr[i] = newarr[i] * newarr[i - 1];
            }
            return newarr;
        }
    }
}
