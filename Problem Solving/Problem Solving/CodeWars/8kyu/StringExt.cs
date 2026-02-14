namespace Problem_Solving.CodeWars._8kyu;

public static class StringExt
{
    public static string ToAlternatingCase(this string s)
    {
        string NewSt = "";
        foreach (var item in s)
        {
            if (item == ' ')
            {
                NewSt += " ";
                continue;
            }
            if (char.IsLower(item))
                NewSt += char.ToUpper(item);
            else
                NewSt += char.ToLower(item);
        }
        return NewSt;
    }
}
