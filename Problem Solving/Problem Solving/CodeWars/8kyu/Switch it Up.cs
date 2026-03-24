using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Switch_it_Up
    {
        public static string SwitchItUp(int number)
        {
            if (number == 1)         
                return "One";
            else if (number == 2) 
                return "Two";
            else if (number == 3)
                return "Three";
            else if (number == 4)
                return "Four";
            else if (number == 5)
                return "Five";
            else if (number == 6)
                return "Six";
            else if (number == 7)
                return "Seven";
            else if (number == 8)
                return "Eight";
            else if (number == 9)
                return "Nine";
            else
                return "Zero";
        }
    }
}
