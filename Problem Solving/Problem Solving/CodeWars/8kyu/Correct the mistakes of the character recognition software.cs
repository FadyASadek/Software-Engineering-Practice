using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public class Correct_the_mistakes_of_the_character_recognition_software
    {
        public static string Correct(string text)
        {
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == 0)
                {
                    text[i] = O;
                }
            }
        }
    }
}
