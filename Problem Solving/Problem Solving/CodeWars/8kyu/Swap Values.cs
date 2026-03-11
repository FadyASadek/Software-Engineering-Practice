namespace Problem_Solving.CodeWars._8kyu;
using System;

public class Swapper
{
    public object[] Arguments { get; private set; }

    public Swapper(object[] args)
    {
        Arguments = args;
    }

    public void SwapValues()
    {
        object[] args = new[] { Arguments[0], Arguments[1] };

        //object temp = args[0];
        //args[0] = args[1];
        //args[1] = temp;

        foreach (var item in args)
        {
            Console.WriteLine(item);
        }
    }
}