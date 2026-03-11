namespace Problem_Solving.CodeWars._8kyu;

public static class Counting_sheep
{
    public static int CountSheeps(bool[] sheeps)
    {
        int counter = 0;
        foreach (var item in sheeps)
        {
            if (item == true)
                counter++;
        }
        return counter;
    }
}
