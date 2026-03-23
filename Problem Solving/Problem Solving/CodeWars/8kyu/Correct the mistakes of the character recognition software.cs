using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public class Correct_the_mistakes_of_the_character_recognition_software
    {
        public static string Correct(string text)=>  text.Replace('0', 'O').Replace('5', 'S').Replace('1', 'I');
    }
}
