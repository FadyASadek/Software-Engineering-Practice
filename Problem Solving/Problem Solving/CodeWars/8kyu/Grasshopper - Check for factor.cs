using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Grasshopper___Check_for_factor
    {
        public static bool CheckForFactor(int num, int factor) => (factor % num) != 0 ? true : false; 
    }
}
