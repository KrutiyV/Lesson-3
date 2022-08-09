using System;

public class Homework3
{
    public static void Main()
    {
        Console.WriteLine("Input first digit");
        int x;
        if (!Int32.TryParse(Console.ReadLine(), out x))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        Console.WriteLine("Input second digit");
        int y; ;
        if (!Int32.TryParse(Console.ReadLine(), out y))
        {
            Console.WriteLine("Invalid input");
            return;
        }

        int placeholder = y;

        if (x > y)
        {
            y = x;
            x = placeholder;
        }

        int sum = x;

        if (x != y)
        {
            placeholder = x;
            do
            {
                placeholder += 1;
                sum = sum + placeholder;
            }
            while (placeholder != y);
        }
        Console.WriteLine($"Sum is {sum}");
    }
}
//checked
