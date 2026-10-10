using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Convert_number_to_reversed_array_of_digits
    {
        public static long[] Digitize(long n) =>
            n.ToString().Select(c => long.Parse((c.ToString())))
            .Reverse()
            .ToArray();
    }
}
