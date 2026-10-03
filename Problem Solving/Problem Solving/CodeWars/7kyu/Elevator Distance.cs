using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._7kyu
{
    public static class Elevator_Distance
    {
        public static int ElevatorDistance(int[] array)
        {
            int counter = 0;
            for (int i = 0; i < array.Length -1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    counter += array[i] - array[i + 1];
                }
                else if (array[i] < array[i + 1])
                {
                    counter += array[i + 1] - array[i];
                }
                else
                {
                    counter += 0;
                }
            }
            return counter;
        }
    }
}
