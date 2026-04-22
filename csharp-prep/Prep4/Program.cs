using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int number = 0;
        Console.WriteLine
        (
            "-------------------------------------------------------------------------------"
        );
        Console.WriteLine("Welcome to the Number Analyzer!");
        Console.WriteLine("Enter a list of numbers, and I'll tell you information about them:");
        Console.WriteLine
        (
            "-------------------------------------------------------------------------------"
        );
        do
        {
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
            
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        while (number != 0);
        Console.WriteLine
        (
            "-------------------------------------------------------------------------------"
        );
        Console.WriteLine("The sum of the numbers is: " + numbers.Sum());
        Console.WriteLine("The average of the numbers is: " + numbers.Average());
        Console.WriteLine("The largest number is: " + numbers.Max());
        Console.WriteLine("The smallest number is: " + numbers.Min());
        Console.WriteLine
        (
            "-------------------------------------------------------------------------------"
        );
    }    
}