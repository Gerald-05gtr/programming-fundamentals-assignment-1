using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n=== Assignment 1: Programming Fundamentals ===");
            Console.WriteLine("1. Two-number calculator");
            Console.WriteLine("2. Temperature converter");
            Console.WriteLine("3. Student grade average");
            Console.WriteLine("0. Exit");
            Console.Write("Select a task: ");
            string choice = (Console.ReadLine() ?? "").Trim();

            switch (choice)
            {
                case "1": Calculator(); break;
                case "2": TemperatureConverter(); break;
                case "3": StudentGradeAverage(); break;
                case "0": Console.WriteLine("Goodbye!"); return;
                default: Console.WriteLine("Invalid menu option. Please try again."); break;
            }
        }
    }

    static double ReadNumber(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine() ?? "";
            if (double.TryParse(input, NumberStyles.Float, CultureInfo.InvariantCulture, out double value)
                && double.IsFinite(value))
                return value;
            Console.WriteLine("Please enter a valid number (use . for decimals).");
        }
    }

    static void Calculator()
    {
        Console.WriteLine("\n--- Two-number calculator ---");
        double first = ReadNumber("Enter the first number: ");
        double second = ReadNumber("Enter the second number: ");
        Console.Write("Choose an operation (+, -, *, /): ");
        string operation = (Console.ReadLine() ?? "").Trim();
        double result;

        if (operation == "+") result = first + second;
        else if (operation == "-") result = first - second;
        else if (operation == "*") result = first * second;
        else if (operation == "/")
        {
            if (second == 0)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
                return;
            }
            result = first / second;
        }
        else
        {
            Console.WriteLine("Invalid operation.");
            return;
        }
        Console.WriteLine($"Result: {result:G}");
    }

    static void TemperatureConverter()
    {
        Console.WriteLine("\n--- Temperature converter ---");
        Console.Write("Enter C for Celsius to Fahrenheit or F for Fahrenheit to Celsius: ");
        string direction = (Console.ReadLine() ?? "").Trim().ToUpperInvariant();
        if (direction != "C" && direction != "F")
        {
            Console.WriteLine("Invalid conversion direction.");
            return;
        }

        double temperature = ReadNumber("Enter the temperature: ");
        if (direction == "C")
        {
            double converted = temperature * 1.8 + 32;
            Console.WriteLine($"{temperature:G}°C = {converted:G}°F");
        }
        else
        {
            double converted = (temperature - 32) / 1.8;
            Console.WriteLine($"{temperature:G}°F = {converted:G}°C");
        }
    }

    static void StudentGradeAverage()
    {
        Console.WriteLine("\n--- Student grade average ---");
        int count;
        while (true)
        {
            Console.Write("How many grades? ");
            if (int.TryParse(Console.ReadLine(), out count) && count > 0)
                break;
            Console.WriteLine("Please enter a positive whole number.");
        }

        double total = 0;
        for (int index = 1; index <= count; index++)
        {
            double grade;
            do
            {
                grade = ReadNumber($"Enter grade {index} (1-6): ");
                if (grade < 1 || grade > 6)
                    Console.WriteLine("Grade must be between 1 and 6.");
            } while (grade < 1 || grade > 6);
            total += grade;
        }

        double average = total / count;
        Console.WriteLine($"Average: {average:F2}");
        if (average >= 3.0)
            Console.WriteLine("The student passed.");
        else
            Console.WriteLine("The student failed.");
    }
}
