
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("Welcome to the Calculator Program \U0001f970");
        Console.WriteLine("Please enter the first number, the operator (+, -, *, /), and then the second number to perform your calculation.");
        Console.WriteLine("=================================================");

        string choice;

        do
        {
            // Get the first number.
            Console.Write("Please, enter the first number: ");

            if (!double.TryParse(Console.ReadLine(), out double firstNumber))
            {
                Console.WriteLine("Invalid number. Please, enter a valid number.");
            }
            else
            {
                // Get the operator.
                Console.Write("Please, enter the required operator (+, -, *, /): ");

                if (!char.TryParse(Console.ReadLine(), out char operation))
                {
                    Console.WriteLine("Invalid operator. Please, enter a single character.");
                }
                else if (operation != '+' && operation != '-' &&
                         operation != '*' && operation != '/')
                {
                    Console.WriteLine("Invalid operator. Please, use +, -, *, or /.");
                }
                else
                {
                    // Get the second number.
                    Console.Write("Please, enter the second number: ");

                    if (!double.TryParse(Console.ReadLine(), out double secondNumber))
                    {
                        Console.WriteLine("Invalid number. Please, enter a valid number.");
                    }
                    else
                    {
                        Console.WriteLine("=================================================");

                        // Perform the calculation.
                        switch (operation)
                        {
                            case '+':
                                Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                                break;

                            case '-':
                                Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                                break;

                            case '*':
                                Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                                break;

                            case '/':
                                if (secondNumber == 0)
                                {
                                    Console.WriteLine("Cannot divide by zero.");
                                }
                                else
                                {
                                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                                }
                                break;
                        }
                    }
                }
            }

            // Ask the user whether to continue.
            Console.WriteLine("=================================================");
            Console.Write("Do you want to perform another calculation? (yes/no): ");
            choice = Console.ReadLine()?.Trim().ToLower() ?? "no";

            Console.WriteLine("=================================================");

        } while (choice == "yes" || choice == "y");

        Console.WriteLine("Thank you for using the Calculator Program \U0001F970");
    }
}
