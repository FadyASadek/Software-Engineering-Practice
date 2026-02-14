namespace Problem_Solving.CodeWars._8kyu;

public static class All_Star_Code_Challenge
{
    public static int StrCount(string str, char letter)
    {
        int counter = 0;
        foreach (var item in str)
        {
            if (item == letter)
            {
                counter++;
            }
        }
        return counter;
    }
}
