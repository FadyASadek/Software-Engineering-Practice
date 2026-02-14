namespace Problem_Solving.CodeWars._8kyu
{
    public static class Beginner_Series_2_Clock
    {
        public static int Past(int h, int m, int s)
        {

            int hours = h * 60 * 60 * 1000;
            int mi = m * 60 * 1000;
            int ss = s * 1000;
            return hours + mi + ss;
        }
    }
}
