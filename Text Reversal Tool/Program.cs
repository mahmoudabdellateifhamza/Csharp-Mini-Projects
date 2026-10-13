
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("===============================================");
        Console.WriteLine("       Text Reversal Tool \U0001F970");
        Console.WriteLine("===============================================");
        Console.WriteLine("Welcome to the Text Reversal Tool ");
        Console.WriteLine();

        do
        {
            // Get the text from the user.
            Console.Write("Please, enter the text to reverse: ");
            string inputText = Console.ReadLine() ?? "";

            // Reverse the text.
            string reversedText = "";

            for (int i = inputText.Length - 1; i >= 0; i--)
            {
                reversedText += inputText[i];
            }

            Console.WriteLine();
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine($"Original text : {inputText}");
            Console.WriteLine($"Reversed text : {reversedText}");
            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine();
            // Ask whether the user wants to reverse another text.
            Console.Write("Do you want to reverse another text? (yes/no): ");
            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("-----------------------------------------------");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
