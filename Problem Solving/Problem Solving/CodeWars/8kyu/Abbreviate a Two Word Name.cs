using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Abbreviate_a_Two_Word_Name
    {
        public static string AbbrevName(string name)
        {
            string[] names = name.Split(' ');
            char s1 = names[0][0]; 
            char s2 = names[1][0]; 
            return $"{s1.ToString().ToUpper()}.{s2.ToString().ToUpper()}";
        }
    }
}
