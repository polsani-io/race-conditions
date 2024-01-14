using System;

public class Program
{
    static int counter = 0;

    static void Main(string[] args)
    {
        IncrementCounter();

        Console.WriteLine($"The final value os counter is: {counter}");
    }

    static void IncrementCounter()
    {
        for (int i = 0; i < 1000000; i++)
	        counter++;
    }
}
