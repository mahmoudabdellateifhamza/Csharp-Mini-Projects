
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("       Arithmetic Mean Calculator \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Arithmetic Mean Calculator");
        Console.WriteLine();

        do
        {
            int numberOfValues;

            Console.Write("Please, enter the number of values: ");

            // Validate the number of values.
            while (!int.TryParse(Console.ReadLine(), out numberOfValues) ||
                   numberOfValues <= 0)
            {
                Console.WriteLine(
                    "Invalid input! Please enter an integer greater than zero.");

                Console.Write("Please, enter the number of values again: ");
            }

            double sum = 0;
            bool validInput = true;

            // Read the values and calculate their sum.
            for (int i = 1; i <= numberOfValues; i++)
            {
                double number;

                Console.Write($"Please, enter number ({i}): ");

                // Validate each entered value.
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

                    Console.Write($"Please, enter number ({i}) again: ");
                }

                sum += number;

                if (double.IsInfinity(sum))
                {
                    validInput = false;
                    break;
                }
            }

            if (!validInput)
            {
                Console.WriteLine(
                    "The total is too large to calculate accurately.");
            }
            else
            {
                // Calculate the average.
                double average = sum / numberOfValues;

                Console.WriteLine();
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine($"Number of values = {numberOfValues}");
                Console.WriteLine($"Sum               = {sum:N2}");
                Console.WriteLine($"Average           = {average:N2}");
                Console.WriteLine("--------------------------------------------");
            }

            Console.WriteLine();

            Console.Write("Do you want to calculate another average? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
