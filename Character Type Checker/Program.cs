
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("===============================================");
        Console.WriteLine("       Character Type Checker \U0001F970");
        Console.WriteLine("===============================================");
        Console.WriteLine("Welcome to the Character Type Checker ");
        Console.WriteLine();

        do
        {
            string input;
            char character;

            Console.Write("Please, enter a single character: ");
            input = Console.ReadLine() ?? "";

            // Validate that the user enters exactly one character.
            while (input.Length != 1)
            {
                Console.WriteLine(
                    "Invalid input! Please enter exactly one character.");

                Console.Write("Please, enter a single character again: ");
                input = Console.ReadLine() ?? "";
            }

            character = input[0];

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");

            // Check whether the character is a lowercase letter.
            if (character >= 'a' && character <= 'z')
            {
                Console.WriteLine("Character type: Lowercase Letter");
            }
            // Check whether the character is an uppercase letter.
            else if (character >= 'A' && character <= 'Z')
            {
                Console.WriteLine("Character type: Uppercase Letter");
            }
            // Check whether the character is a digit.
            else if (character >= '0' && character <= '9')
            {
                Console.WriteLine("Character type: Digit");
            }
            // Handle all other characters.
            else
            {
                Console.WriteLine("Character type: Special Character");
            }

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to check another character? (yes/no): ");
            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970 ");
    }
}
