using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class What_is_between
    {
        public static int[] Between(int a, int b)
        {
            List<int> result = new List<int>();
            for (int i = a; i <= b ; i++)
               result.Add(i);
            return result.ToArray();    
        }
    }
}
