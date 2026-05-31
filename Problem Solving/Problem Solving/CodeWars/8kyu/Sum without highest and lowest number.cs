using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Sum_without_highest_and_lowest_number
    {
        public static int Sum(int[] numbers)
        {
            if ( numbers is null || numbers.Length <= 2)
                return 0;
            var list = new List<int>(numbers);
            list.Remove(list.Max());
            list.Remove(list.Min());
            return list.Sum();
        }
    }
}
