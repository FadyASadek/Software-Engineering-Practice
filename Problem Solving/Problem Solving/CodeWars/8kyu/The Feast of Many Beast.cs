using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class The_Feast_of_Many_Beast
    {
        public static bool Feast(string beast, string dish)=>
            beast[0] == dish[0] && beast[beast.Length - 1] == dish[dish.Length - 1];
    }
}
