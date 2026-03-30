using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Parse_nice_int_from_char_problem
    {
        public static int GetAge(string inputString)
        {
            string[] strings = inputString.Split(' ');
            return int.Parse(strings[0]);
        }
    }
}
