using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Expressions_Matter
    {
        public static int ExpressionsMatter(int a, int b, int c)
        {
            List<int> list = new List<int>();
            int first = a + b + c;
            int sec = a * b * c;
            int th = a + b * c;
            int fourth = a * (b + c);
            int five = (a + b) * c;
            list.Add(first);
            list.Add(sec);
            list.Add(th);
            list.Add(fourth);
            list.Add(five);
            return list.Max();
        }
    }
}
