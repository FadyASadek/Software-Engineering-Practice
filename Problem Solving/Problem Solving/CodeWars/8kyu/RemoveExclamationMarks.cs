namespace Problem_Solving.CodeWars._8kyu;

public static class RemoveExclamationMarksClass
{
    public static string RemoveExclamationMarks(string s)
    {
        char[] chars = s.ToCharArray();
        string test = "";
        foreach (var item in chars)
        {
            if (item != '!')
            {
                test += item;
            }
        }
        return test;
    }
}
