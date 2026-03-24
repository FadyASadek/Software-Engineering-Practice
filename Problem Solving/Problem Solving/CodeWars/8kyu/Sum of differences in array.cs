using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Sum_of_differences_in_array
    {
        public static int SumOfDifferences(int[] arr)
        {
            if (arr == null || arr.Length == 1)
            {
                return 0;
            }
            else
            {
                var newlist = arr.OrderByDescending(x=>x).ToList();
                int num = 0;
                for (int i = 0; i < newlist.Count; i++)
                {
                    if(i == newlist.Count - 1)
                    {
                        break;
                    }
                   num = newlist[i] - newlist[i + 1];
                }
                return num;
            }
        }
    }
}
