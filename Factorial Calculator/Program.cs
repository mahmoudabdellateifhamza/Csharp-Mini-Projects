
using System;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("       Factorial Calculator \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Factorial Calculator ");
        Console.WriteLine();

        do
        {
            int number;

            Console.Write("Enter a non-negative integer: ");
            // Validate the input and ensure the number is non-negative.
            while (!int.TryParse(Console.ReadLine(), out number) ||
                   number < 0) 
            {
                Console.WriteLine(
                    "Invalid input! Please enter a non-negative integer.");

                Console.Write("Please, enter the number again: ");
            }

            // Calculate the factorial using BigInteger.
            BigInteger factorial = BigInteger.One;

            for (int i = 1; i <= number; i++)
            {
                factorial *= i;
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"{number}! = {factorial}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to calculate another factorial? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
