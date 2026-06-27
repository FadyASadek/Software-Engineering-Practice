using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Thinkful__Logic_Drills_Traffic_light
    {
        public static string UpdateLight(string current) => (current == "red") ? "green" :
            (current == "green") ? "yellow" : "red";
    }
}
