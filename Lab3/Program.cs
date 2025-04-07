﻿using System;

  class Program
  {
    static void Main(string[] args)
    {
      // --- Part 1: Operator Practice ---
        int a = 10;
        int b = 5;
        int c = 15;

        Console.WriteLine("Part 1: Operator Practice");
        Console.WriteLine("a > b: " + (a > b));
        Console.WriteLine("a < c: " + (a < c));
        Console.WriteLine("a > b && a > c: " + (a > b && a > c));
        Console.WriteLine("a > b || a > c: " + (a > b || a > c));
        Console.WriteLine();

        
        bool isRaining = true;
        bool haveUmbrella = false;

        
        if (isRaining && !haveUmbrella)
        {
            Console.WriteLine("Take an umbrella!");
        }
        else
        {
            Console.WriteLine("You're good to go!");
        }
        Console.WriteLine();

        
        
        Console.Write("enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        if (age < 5)
        {
            Console.WriteLine("ticket is free!");
        }
        else if (age >= 5 && age <= 12)
        {
            Console.WriteLine("child ticket: $5");
        }
        else if (age >= 13 && age <= 64)
        {
            Console.WriteLine("standard ticket: $10");
        }
        else if (age >= 65)
        {
            Console.WriteLine("senior ticket: $6");
        }
        Console.WriteLine();

        // --- Part 4: Using a switch Statement ---
        Console.WriteLine("Part 4: Day of the Week");
        Console.WriteLine("Enter a number (1–7): ");
        int day = Convert.ToInt32(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day!");
                break;
        }
    }
  }