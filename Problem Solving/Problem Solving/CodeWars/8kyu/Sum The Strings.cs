using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Sum_The_Strings
    {
        public static string StringsSum(string s1, string s2)
        {
            if (s1 == "")
            {
                s1 = "0";
            }
             if(s2 == "")
                s2 = "0";
            return (int.Parse(s1) + int.Parse(s2)).ToString();
        }
    }
}
