
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("    Years to Hours Converter \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Years to Hours Converter ");
        Console.WriteLine();

        do
        {
            double numberOfYears;

            Console.Write("Please, enter the number of years: ");

            while (!double.TryParse(
                Console.ReadLine(),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out numberOfYears) ||
                double.IsNaN(numberOfYears) ||
                double.IsInfinity(numberOfYears) ||
                numberOfYears < 0)
            {
                Console.WriteLine(
                    "Invalid input! Please enter a valid non-negative number.");

                Console.Write("Please, enter the number of years again: ");
            }

            // Assume each year contains 365 days.
            double numberOfHours = numberOfYears * 365 * 24;

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Number of years = {numberOfYears}");
            Console.WriteLine($"Number of hours = {numberOfHours}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to convert another value? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("============================================");
        Console.WriteLine("Thank you for using the program  \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
