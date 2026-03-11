namespace Problem_Solving.CodeWars._8kyu;

public static class Basic_Mathematical_Operations
{
    public static double basicOp(char operation, double value1, double value2)
    {
        if (operation == '+')
            return value1 + value2;
        if (operation == '-')
            return value1 - value2;
        if (operation == '*')
            return value1 * value2;
        else
            return value1 / value2;
    }
}
