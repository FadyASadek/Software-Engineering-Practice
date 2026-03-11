namespace Problem_Solving.CodeWars._8kyu;
using System.Linq;
public static class Calculate_average
{
    public static double FindAverage(double[] array) => array.Length == 0 ? 0 : (double)(array.Sum() / array.Length);
}
