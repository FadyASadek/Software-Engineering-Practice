using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._7kyu
{
    public static class Number_climber
    {
        public static int[] Climb(int n)
        {
            var list = new List<int>();
            list.Add(n);
            while (n > 1)
            {
                list.Add(Math.Abs(n / 2));
                n = Math.Abs(n / 2);
            }
            list.Reverse();
            return list.ToArray();
        }
    }
}
