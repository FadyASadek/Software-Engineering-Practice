using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class DNA_to_RNA_Conversion
    {
        public static string dnaToRna(string dna) => dna.Replace('T', 'U').ToString();
        
    }
}
