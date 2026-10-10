using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._7kyu
{
    public static class Sum_of_array_singles
    {
        public static int Repeats(List<int> source)
        {
            List<int> newlist = new List<int>();
            for (int i = 0; i < source.Count; i++)
            {
                if (newlist.Contains(source[i]))
                {
                    newlist.Remove(source[i]);
                }
                else
                {
                    newlist.Add(source[i]);
                }
            }
            return newlist.Sum();
        }
    }
}
