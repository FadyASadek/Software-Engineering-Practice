using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Total_amount_of_points
    {
        public static int TotalPoints(string[] games)
        {
            int x=0, y = 0;
            for (int i = 0; i < games.Length; i++)
            {
                string[] st = games[i].Split(':');
                if (st[0] == st[1])
                {
                    x += 1;
                    y += 1;
                }
                else if (int.Parse(st[0]) > int.Parse(st[1]))
                {
                    x += 3;
                }
                else
                    y += 3;
            }
            return x>y ? x: 0;
        }
    }
}
