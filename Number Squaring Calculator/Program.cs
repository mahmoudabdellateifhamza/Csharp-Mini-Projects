
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("       Number Squaring Calculator \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Number Squaring Calculator");
        Console.WriteLine();

        do
        {
            double number;

            Console.Write("Please, enter a number: ");

            // Validate the input to ensure it is a valid number.
            while (!double.TryParse(
                Console.ReadLine(),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out number) ||
                double.IsNaN(number) ||
                double.IsInfinity(number))
            {
                Console.WriteLine(
                    "Invalid input! Please enter a valid number.");

                Console.Write("Please, enter the number again: ");
            }

            // Calculate the square by multiplying the number by itself.
            double square = number * number;

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Square = {number} * {number} = {square}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to calculate another square? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
