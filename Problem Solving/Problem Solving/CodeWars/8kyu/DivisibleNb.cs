namespace Problem_Solving.CodeWars._8kyu
{
    public class DivisibleNb
    {
        public static bool IsDivisible(int n, int x, int y) => (n % x == 0 && n % y == 0) ? true : false;
    }
}
