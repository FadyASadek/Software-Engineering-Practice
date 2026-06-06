using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Replace_all_vowel_to_exclamation_mark_in_the_sentence
    {
        public static string Replace(string s)
        {
            for (var i = 0; i < s.Length; i++)
            {
                if ("aeiouAEIOU".Contains(s[i]))
                {
                    s = s.Remove(i,1).Insert(i, "!");

                }
            }
        }
    }
}
