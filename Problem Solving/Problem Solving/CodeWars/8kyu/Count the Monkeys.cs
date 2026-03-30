using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Count_the_Monkeys
    {
        public static int[] MonkeyCount(int n)
        {
            return Enumerable.Range(1,n).ToArray();
        }
    }
}
