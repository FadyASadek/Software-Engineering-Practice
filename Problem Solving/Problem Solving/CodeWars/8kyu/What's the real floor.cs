namespace Problem_Solving.CodeWars;

public static class What_s_the_real_floor
{
    public static int GetRealFloor(int n)
       => (n < 13) ? n - 1 : n - 2;
}
