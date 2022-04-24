using System;

public class Output
{
    public static void Interval(int[] input)
    {
        int freq = 0;

        if (input.Length > 256)
        {
            freq = 50;
        }
        else
        {
            freq = 10;
        }

        Console.WriteLine("\nDisplaying every " + freq + "th in sorted file.\n");

        for(int i = 0; i <= input.Length; i = i + freq)
        {
            Console.WriteLine(input[i]);
        }

        Console.WriteLine("\nNo more intervals available.");
    }
}
