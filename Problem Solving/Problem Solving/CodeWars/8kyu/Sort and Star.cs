using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Sort_and_Star

    {
        public static string TwoSort(string[] s)
        {
            var newlist = new List<string>(s);
            newlist.Sort(StringComparer.Ordinal);
            string newstring = "";
            for (int i = 0; i < newlist[0].Length; i++)
            {
                newstring += newlist[0][i];
                if(i != newlist[0].Length -1)
                newstring += "***";
            }
            return newstring;
        }
    }
}
