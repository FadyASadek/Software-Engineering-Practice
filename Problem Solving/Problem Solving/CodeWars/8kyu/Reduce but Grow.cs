namespace Problem_Solving.CodeWars._8kyu;

public static class Reduce_but_Grow
{
    public static int Grow(int[] x)
    {
        int test = 1;
        foreach (int i in x)
            test *= i;
        return test;
    }
}
