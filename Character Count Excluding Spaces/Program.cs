
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("=================================================");
        Console.WriteLine("       Character Counter \U0001F970");
        Console.WriteLine("=================================================");
        Console.WriteLine("Welcome to the Character Counter ");
        Console.WriteLine();

        do
        {
            // Get the text from the user.
            Console.Write("Please, enter the text to count its characters: ");
            string inputText = Console.ReadLine() ?? "";

            int characterCount = 0;
            // Count every character except whitespace.
            for (int i = 0; i < inputText.Length; i++)
            {
                if (!char.IsWhiteSpace(inputText[i]))
                {
                    characterCount++;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine($"Input text                         = {inputText}");
            Console.WriteLine($"Number of characters without spaces = {characterCount}");
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();

            // Ask whether the user wants to count another text.
            Console.Write("Do you want to count another text? (yes/no): ");
            choice = (Console.ReadLine() ?? "no").Trim().ToLower();
            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Thank you for using the program  \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
