using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem_Solving.CodeWars._7kyu
{
    public static class Simple_string_reversal
    {
        public static String solve(String s)
        {
            string st = s.Replace(" ","");
            string x = new string (st.Reverse().ToArray());
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' ')
                {
                   x= x.Insert(i, " ");
                }
            }
            return x;
        }
    }
}
