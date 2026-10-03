using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Simple_Fun_Seats_in_Theater
    {
        public static int SeatsInTheater(int nCols, int nRows, int col, int row) => (nCols - col + 1) * (nRows - row);
    }
}
