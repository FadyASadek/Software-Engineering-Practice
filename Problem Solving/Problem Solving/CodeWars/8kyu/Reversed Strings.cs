namespace Problem_Solving.CodeWars._8kyu
{
    public static class Reversed_Strings
    {
        public static string Solution(string str)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);
            return new string(ch);
        }
    }
}
