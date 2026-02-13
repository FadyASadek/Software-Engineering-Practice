namespace Problem_Solving.CodeWars._8kyu;

public static class MangoClass
{
    public static int Mango(int quantity, int price)
    {
        if (quantity >= 3)
        {
            int test = quantity / 3;
            return (quantity - test) * price;
        }
        return quantity * price;
    }
}
