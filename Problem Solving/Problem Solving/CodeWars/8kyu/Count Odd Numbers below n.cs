namespace Problem_Solving.CodeWars._8kyu;

public static class Count_Odd_Numbers_below_n
{
    public static ulong OddCount(ulong n)
    {
        ulong counter = 0;
        for (ulong i = 0; i < n; i++)
        {
            if (i % 2 != 0)
                counter++;
        }
        return counter;
    }

}
