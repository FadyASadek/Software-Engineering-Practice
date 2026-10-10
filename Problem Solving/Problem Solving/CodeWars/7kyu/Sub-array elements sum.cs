using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._7kyu
{
    public static class Sub_array_elements_sum
    {
            public static int ElementsSum(int[][] arr, int d = 0)
            {
                int counter = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    int index = (arr.Length - i - 1);
                    if (index >= arr[i].Length)
                    {
                        counter += d;
                    }
                    else
                    {
                        counter += arr[i][index];
                    }
                }
                return counter;
            }
    }
}
