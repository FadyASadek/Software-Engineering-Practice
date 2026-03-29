using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class If_you_can_t_sleep__just_count_sheep
    {
        public static string CountSheep(int n)
        {
            string result = "";
            for (int i = 1; i <= n; i++)
            {
                result += $"{i} sheep...";
            }
            return result;
        }
    }
}
