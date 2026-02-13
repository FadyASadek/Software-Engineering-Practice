namespace Problem_Solving.CodeWars._8kyu;

public static class String_repeat
{
    public static string RepeatStr(int n, string s)
    {
        string test = "";
        for (int i = 0; i < n; i++)
            test += s;
        return test;
    }
}
