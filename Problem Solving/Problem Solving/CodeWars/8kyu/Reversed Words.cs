using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem_Solving.CodeWars._8kyu
{
    public static class Reversed_Words
    {
        public static string ReverseWords(string str)
        {
            string[] arr = str.Split(' ').Reverse().ToArray();
            return string.Join(" ", arr);
        }
    }
}
