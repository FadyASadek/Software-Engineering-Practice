using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Do_I_get_a_bonus
    {
        public static string bonus_time(int salary, bool bonus) => (bonus) ? $"${(salary * 10)}" : $"${salary}";
    }
}
