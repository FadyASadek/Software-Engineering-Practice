namespace Problem_Solving.CodeWars._8kyu
{
    public static class Return_Negative
    {
        public static int MakeNegative(int number) => number.ToString()[0] == '-' ? number : (number == 0) ? number : -number;
    }
}
