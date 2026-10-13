
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("=================================================");
        Console.WriteLine("       Duplicate Character Counter \U0001F970");
        Console.WriteLine("=================================================");
        Console.WriteLine("Welcome to the Duplicate Character Counter ");
        Console.WriteLine();

        do
        {
            // Get the text from the user.
            Console.Write("Please, enter a word or text: ");
            string inputText = Console.ReadLine() ?? "";

            // Store each character and its occurrence count.
            Dictionary<char, int> characterCounts = new Dictionary<char, int>();

            // Count the occurrences of each character.
            foreach (char character in inputText.ToLower())
            {
                // Ignore whitespace characters.
                if (char.IsWhiteSpace(character))
                {
                    continue;
                }

                if (characterCounts.ContainsKey(character))
                {
                    characterCounts[character]++;
                }
                else
                {
                    characterCounts[character] = 1;
                }
            }

            Console.WriteLine();
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Repeated Characters:");
            Console.WriteLine("-------------------------------------------------");

            bool hasDuplicates = false;

            // Display only characters that appear more than once.
            foreach (KeyValuePair<char, int> item in characterCounts)
            {
                if (item.Value > 1)
                {
                    Console.WriteLine(
                        $"Character '{item.Key}' appeared {item.Value} times.");

                    hasDuplicates = true;
                }
            }

            if (!hasDuplicates)
            {
                Console.WriteLine("No repeated characters were found.");
            }

            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine();
            // Ask whether the user wants to check another text.
            Console.Write("Do you want to check another word or text? (yes/no): ");
            choice = (Console.ReadLine() ?? "no").Trim().ToLower();
            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
