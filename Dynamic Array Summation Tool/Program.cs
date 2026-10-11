
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("       Dynamic Array Summation Tool \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Dynamic Array Summation Tool ");
        Console.WriteLine();

        do
        {
            int numberOfElements;

            Console.Write("Please, enter the number of array elements: ");

            // Validate the number of elements.
            while (!int.TryParse(Console.ReadLine(), out numberOfElements) ||
                   numberOfElements <= 0)
            {
                Console.WriteLine(
                    "Invalid input! Please enter a positive integer.");

                Console.Write("Please, enter the number of elements again: ");
            }

            // Create an array based on the user's choice.
            double[] numbers = new double[numberOfElements];
            double sum = 0;

            // Read the elements and calculate their sum.
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Please, enter number ({i + 1}): ");

                // Validate each entered number.
                while (!double.TryParse(
                    Console.ReadLine(),
                    NumberStyles.Float,
                    CultureInfo.InvariantCulture,
                    out numbers[i]) ||
                    double.IsNaN(numbers[i]) ||
                    double.IsInfinity(numbers[i]))
                {
                    Console.WriteLine(
                        "Invalid input! Please enter a valid number.");

                    Console.Write($"Please, enter number ({i + 1}) again: ");
                }

                sum += numbers[i];
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Numbers entered:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Number ({i + 1}) = {numbers[i]}");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Number of elements = {numbers.Length}");
            Console.WriteLine($"Sum of the array   = {sum}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to calculate another sum? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
