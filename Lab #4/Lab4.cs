using System;

class Program
{
    static void Main(string[] args)
    {
        // Problem 1: Simple For Loop
        Console.WriteLine("Problem 1: Numbers 1 to 10");
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nProblem 2: Even Numbers from 1 to 20");
        // Problem 2: Even Numbers from 1 to 20
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("\nProblem 3: Countdown from 5 to 1");
        // Problem 3: While Loop Countdown
        int countdown = 5;
        while (countdown >= 1)
        {
            Console.WriteLine(countdown);
            countdown--;
        }

        Console.WriteLine("\nProblem 4: User Input Greater Than 100");
        // Problem 4: Do/While User Input
        int userInput;
        do
        {
            Console.Write("Enter a number greater than 100: ");
            userInput = Convert.ToInt32(Console.ReadLine());
        } while (userInput <= 100);

        Console.WriteLine("\nProblem 5: Multiples of 10 from 10 to 1000");
        // Problem 5: While Loop Multiples of 10
        int num = 10;
        while (num <= 1000)
        {
            Console.WriteLine(num);
            num += 10;
        }

        Console.WriteLine("\nProblem 6: Pattern Printer");
        // Problem 6: Pattern Printer Using Nested Loops
        for (int row = 1; row <= 10; row++)
        {
            for (int star = 1; star <= row; star++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}
