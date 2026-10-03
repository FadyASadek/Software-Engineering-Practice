using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace Problem_Solving.CodeWars._7kyu
{
    public static class Find_Count_of_Most_Frequent_Item_in_an_Array
    {
        public static int MostFrequentItemCount(int[] collection)
        {
            if (collection.Length == 0)
            {
                return 0;
            }
            Dictionary<int, int> keyValues = new();
            for (int i = 0; i < collection.Length; i++)
            {
                if (keyValues.ContainsKey(collection[i]))
                {
                    keyValues[collection[i]]++;
                }
                else
                {
                    keyValues[collection[i]] = 1;
                }
            }
            return keyValues.Values.Max();
        }
    }
}
