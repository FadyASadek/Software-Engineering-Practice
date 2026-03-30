using System;
using System.Collections.Generic;
using System.Text;

namespace Problem_Solving.CodeWars._8kyu
{
    public static class Multiplication_table_for_number
    {
        public static string MultiTable(int number)
        {
            return $"1 * {number} = {1*number}\n2 * {number} = {2*number}\n3 * {number} = {3*number}\n4 * {number} = {4*number}\n5 * {number} = {5*number}\n6 * {number} = {number*6}\n7 * {number} = {number*7}\n8 * {number} = {number*8}\n9 * {number} = {number*9}\n10 * {number} = {number*10}";
        }
    }
}
