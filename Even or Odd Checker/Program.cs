
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("       Even or Odd Checker \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Even or Odd Checker ");
        Console.WriteLine();

        do
        {
            int number;

            Console.Write("Please, enter an integer number: ");

            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine(
                    "Invalid input! Please enter a valid integer.");

                Console.Write("Please, enter the number again: ");
            }

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");

            // Check whether the number is even or odd.
            if (number % 2 == 0)
            {
                Console.WriteLine($"The number {number} is even.");
            }
            else
            {
                Console.WriteLine($"The number {number} is odd.");
            }

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to check another number? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine("Thank you for using the program  \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
