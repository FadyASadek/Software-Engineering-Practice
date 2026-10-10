using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Twice_as_old
    {
        public static int TwiceAsOld(int dadYears, int sonYears)=>
             Math.Abs( sonYears * 2 - dadYears);
    }
}
