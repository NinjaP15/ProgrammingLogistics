using System;

class Program
{
    static void Main()
    {
        // Problem 1: Seasons of the Year
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        Console.WriteLine("Problem 1: Seasons of the Year");
        foreach (string season in seasons)
        {
            Console.WriteLine("Season: " + season);
        }

        // Problem 2: Days of the Week (1–7)
        Console.WriteLine("\nProblem 2: Days of the Week (1–7)");
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1–7): ");
        if (int.TryParse(Console.ReadLine(), out int dayNumber) && dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine("That day is: " + days[dayNumber - 1]);
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 7.");
        }

        // Problem 3: Favorite Books and Authors
        Console.WriteLine("\nProblem 3: Favorite Books and Authors");
        string[] books = { "Alone at Dawn", "Charlotte’s Web", "1984" };
        string[] authors = { "Dan Schilling and Lori Chapman Longfritz", "E.B. White", "George Orwell" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"Book {i + 1}: {books[i]} by {authors[i]}");
        }

        // Problem 4: Temperature Tracker
        Console.WriteLine("\nProblem 4: Temperature Tracker");
        int[] temperatures = { 80, 67, 54, 73, 61 };
        Array.Sort(temperatures);

        Console.Write("Sorted Temperatures: ");
        foreach (int temp in temperatures)
        {
            Console.Write(temp + " ");
        }

        Console.WriteLine($"\nHighest Temperature: {temperatures[^1]}");
        Console.WriteLine($"Lowest Temperature: {temperatures[0]}");

        // Problem 5: Reverse Countdown
        Console.WriteLine("\nProblem 5: Reverse Countdown");
        int[] countdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(countdown);

        Console.Write("Countdown: ");
        for (int i = 0; i < countdown.Length; i++)
        {
            Console.Write(countdown[i] + " ");
        }

        Console.WriteLine();
    }
}
