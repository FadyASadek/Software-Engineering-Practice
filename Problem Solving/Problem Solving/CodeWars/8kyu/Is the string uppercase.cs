namespace Problem_Solving.CodeWars._8kyu;

public static class Is_the_string_uppercase
{
    public static bool IsUpperCase(this string text)
    {
        char[] chars = text.ToCharArray();
        foreach (var item in chars)
        {
            if (char.IsLower(item))
                return false;
        }
    }
}
