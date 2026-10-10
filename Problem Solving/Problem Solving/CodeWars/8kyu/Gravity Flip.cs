using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem_Solving.CodeWars._8kyu
{
    public static class Gravity_Flip
    {
        public static int[] Flip(char dir, int[] arr)
        {
            
            if (dir == 'R')
            {
                Array.Sort(arr);
                return arr;
            }
            else
            {
                Array.Sort(arr);
                var newarr = arr.Reverse().ToArray();
                return newarr;
            }
        }
    }
}
