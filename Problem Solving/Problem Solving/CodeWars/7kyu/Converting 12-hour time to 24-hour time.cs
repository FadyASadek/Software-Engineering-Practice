using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Problem_Solving.CodeWars._7kyu
{
    public static class Converting_12_hour_time_to_24_hour_time
    {
        public static string Convert12hTo24h(int hours, int minutes, string period)
        {       
            if (hours >= 12)
            {
                if (period == "am")
                    return $"{(hours - 12).ToString("D2")}{minutes.ToString("D2")}";
                else
                    return $"{hours.ToString("D2")}{minutes.ToString("D2")}";
            }
            else
            {
                if (period == "pm")
                    return $"{(hours + 12).ToString("D2")}{minutes.ToString("D2")}";
                else
                    return $"{hours.ToString("D2")}{minutes.ToString("D2")}";
            }
        }
    }
}
