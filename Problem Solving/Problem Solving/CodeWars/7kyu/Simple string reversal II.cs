using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem_Solving.CodeWars._7kyu
{
    public static class Simple_string_reversal_II
    {
        public static String solve(String s, int a, int b)
        {
            b = Math.Min(b, s.Length - 1);
            string st = s[a..(b+1)];
            string x = new string(st.Reverse().ToArray());
            string s2 = s[..a] + s[(b + 1)..];
            s2 = s2.Insert(a, x);
            return s2 ;
        }
    }
}
