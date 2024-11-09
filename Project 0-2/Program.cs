﻿using System;
internal class Program
{
    public static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("************************************");
            Console.WriteLine("*  The stars shine in Greenville.  *");
            Console.WriteLine("************************************\n");

            Console.WriteLine("Please Enter the following number below from the following menu:");
            Console.WriteLine("1. CALCULATE Greenville Revenue Year-Over-Year");
            Console.WriteLine("2. Exit\n");

            int choice = GetMenuChoice();

            switch (choice)
            {
                case 1:
                    CalculateRevenue();
                    break;
                case 2:
                    Console.WriteLine("Thank you for using the Greenville Revenue App, good-bye!");
                    running = false;
                    break;
            }

            if (running)
            {
                Console.WriteLine("\nPress Enter to return to the main menu...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
    private static int GetMenuChoice()
    {
        int choice;
        Console.Write("Enter your choice (1 or 2): ");
        while (!int.TryParse(Console.ReadLine(), out choice) || (choice != 1 && choice != 2))
        {
            Console.Write("Invalid selection. Please enter '1' to calculate revenue or '2' to exit: ");
        }
        return choice;
    }
    private static int GetInput(string prompt)
    {
        int result;
        Console.Write(prompt);
        while (!int.TryParse(Console.ReadLine(), out result) || result < 0)
        {
            Console.Write("Invalid input. Enter a positive valid number: ");
        }
        return result;
    }
    private static void CalculateRevenue()
    {
        Console.WriteLine("We will calculate the revenue for this year.");
        int lastYearContestants = GetInput("Enter last year's number of contestants: ");
        int thisYearContestants = GetInput("Enter this year's number of contestants: ");

        int ticketPrice = 25;
        int revenue = thisYearContestants * ticketPrice;
        bool greaterThan = thisYearContestants > lastYearContestants;

        Console.WriteLine($"\nLast year's competition had {lastYearContestants} contestants, and this year's has {thisYearContestants} contestants.");
        Console.WriteLine($"Revenue expected this year is ${revenue}");
        Console.WriteLine($"It is {greaterThan.ToString().ToLower()} that this year's competition is bigger than last year's.\n");
    }
}