using System;

class Program
{
    static void Main()
    {
        
        string[] seasons = { "Spring", "Summer", "Fall", "Winter" };
        foreach (string season in seasons)
        {
            Console.WriteLine("Season: " + season);
        }

        Console.WriteLine();

        
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number (1–7): ");
        string input = Console.ReadLine();
        int dayNum = Convert.ToInt32(input);
        if (dayNum >= 1 && dayNum <= 7)
        {
            Console.WriteLine("That day is: " + days[dayNum - 1]);
        }
        else
        {
            Console.WriteLine("Invalid number. Please enter a number from 1 to 7.");
        }

        Console.WriteLine();

        
        string[] books = { "The Hobbit", "The Martian", "1984" };
        string[] authors = { "J.R.R. Tolkien", "Andy Weir", "George Orwell" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(books[i] + " by " + authors[i]);
        }

        Console.WriteLine();

        
        int[] temperatures = { 65, 72, 78, 70, 68 };
        Array.Sort(temperatures);
        Console.Write("Sorted Temperatures: ");
        for (int i = 0; i < temperatures.Length; i++)
        {
            Console.Write(temperatures[i] + " ");
        }
        Console.WriteLine();
        Console.WriteLine("Highest Temperature: " + temperatures[temperatures.Length - 1]);
        Console.WriteLine("Lowest Temperature: " + temperatures[0]);

        Console.WriteLine();

        
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
