namespace Problem_Solving.CodeWars._8kyu;

public static class Will_you_make_it
{
    public static bool ZeroFuel(uint distanceToPump, uint mpg, uint fuelLeft) => mpg * fuelLeft >= distanceToPump;
}
