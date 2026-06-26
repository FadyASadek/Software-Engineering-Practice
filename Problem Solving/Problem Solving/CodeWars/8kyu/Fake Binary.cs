using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;
using System.Linq;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Fake_Binary
    {
        public static string FakeBin(string x)
        {
            return string.Join("", x.ToList().Select(x=> int.Parse(x.ToString()) > 5 ? "1" : "0"));
        }
    }
}
