
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("    Days to Hours Converter \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Days to Hours Converter ");
        Console.WriteLine();

        do
        {
            double numberOfDays;

            Console.Write("Please, enter the number of days: ");

            while (!double.TryParse(
                Console.ReadLine(),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out numberOfDays) ||
                double.IsNaN(numberOfDays) ||
                double.IsInfinity(numberOfDays) ||
                numberOfDays < 0)
            {
                Console.WriteLine(
                    "Invalid input! Please enter a valid non-negative number.");

                Console.Write("Please, enter the number of days again: ");
            }

            // Convert days to hours.
            double numberOfHours = numberOfDays * 24;

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Number of days  = {numberOfDays}");
            Console.WriteLine($"Number of hours = {numberOfHours}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to convert another value? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("============================================");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
