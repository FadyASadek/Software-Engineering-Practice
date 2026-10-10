using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._7kyu
{
    public static class From_A_to_Z
    {
        public static string GimmeTheLetters(string sp)
        {
            int start =(char)sp[0];
            int end = (char)sp[2];
            string newstring = "";
            for (int i = start; i <= end; i++)
            {
                newstring += (char)i;
            }
            return newstring;
        }
    }
}
