using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Opposites_Attract
    {
        public static bool lovefunc(int flower1, int flower2) => (flower1 % 2 == 0 && flower2 % 2 != 0) || (flower1 % 2 != 0 && flower2 % 2 == 0);
    }
}
