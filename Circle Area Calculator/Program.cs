
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        string choice;

        Console.WriteLine("============================================");
        Console.WriteLine("     Circle Area Calculator \U0001F970");
        Console.WriteLine("============================================");
        Console.WriteLine("Welcome to the Circle Area Calculator");
        Console.WriteLine();

        do
        {
            double radius;

            Console.Write("Please, enter the radius of the circle: ");

            while (!double.TryParse(
                Console.ReadLine(),
                NumberStyles.Float,
                CultureInfo.InvariantCulture,
                out radius) || radius < 0)
            {
                Console.WriteLine(
                    "Invalid input! Please enter a valid positive number.");

                Console.Write("Please, enter the radius again: ");
            }

            double area = Math.PI * radius * radius;

            Console.WriteLine();
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"Radius of the circle = {radius:F2}");
            Console.WriteLine($"Area of the circle   = {area:F2}");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();

            Console.Write("Do you want to calculate another circle? (yes/no): ");

            choice = (Console.ReadLine() ?? "no").Trim().ToLower();

            Console.WriteLine();

        } while (choice == "yes" || choice == "y");
        Console.WriteLine("============================================");
        Console.WriteLine("Thank you for using the program \U0001F970");
        Console.WriteLine("Goodbye \U0001f970");
    }
}
