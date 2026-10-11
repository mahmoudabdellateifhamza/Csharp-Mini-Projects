
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("==================================================");
        Console.WriteLine("       Leap Year Checker \U0001F970");
        Console.WriteLine("==================================================");
        Console.WriteLine("Welcome to the Leap Year Checker ");
        Console.WriteLine();

        do
        {
            int year;

            Console.Write("Please, enter a year to check: ");

            while (!int.TryParse(Console.ReadLine(), out year) || year <= 0)
            {
                Console.WriteLine(
                    "Invalid input! Please enter a valid positive year.");

                Console.Write("Please, enter the year again: ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------");

            // Check whether the year is a leap year.
            if (year % 400 == 0 ||
                (year % 4 == 0 && year % 100 != 0))
            {
                Console.WriteLine($"The year {year} is a leap year.");
                Console.WriteLine("February has 29 days.");
            }
            else
            {
                Console.WriteLine($"The year {year} is not a leap year.");
                Console.WriteLine("February has 28 days.");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to check another year? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("============================================");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
