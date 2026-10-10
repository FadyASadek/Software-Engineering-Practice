using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._7kyu
{
    public static class Alphabet_symmetry
    {
        public static List<int> Solve(List<string> arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Count; i++)
            {
                int counter = 0;
                for (int j = 1; j <= arr[i].Length; j++)
                {
                    if ((char.ToLower(arr[i][j-1]) - 'a' + 1) == j)
                    {
                        counter++;
                    }
                }
                list.Add(counter);
            }
            return list;
        }
    }
}
