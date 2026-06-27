using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Collatz_Conjecture__3n_1_
    {
        public static uint Hotpo(uint n)
        {
            uint counter = 0;
            while (n!=1)
            {
                if (n % 2 == 0)
                {
                    n = n / 2;
                    counter++;
                }
                else
                {
                    n = 3 * n + 1;
                    counter++;

                }
            }
            return counter;
        }
    }
}
