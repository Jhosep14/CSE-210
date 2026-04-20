using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Welcome to Grade System Support");
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);
        int sign = grade % 10;
        string letter = "";

        if (grade >= 90)
        {
            if (sign >= 3 || grade==100)
            {
                letter = "A";
            }
            else if (sign < 3)
            {
                letter = "A-";
            }
            Console.WriteLine("Great Job!.");

        }
        else if (grade >=80)
        {
            if (sign >= 7)
            {
                letter = "B+";
            }
            else if (sign >= 4)
            {
                letter = "B";
            }
            else 
            {
                letter = "B-";
            }
            Console.WriteLine("Good Job!.");
        }
        else if (grade >=70)
        {
            if (sign >= 7)
            {
                letter = "C+";
            }
            else if (sign >= 4)
            {
                letter = "C";
            }
            else 
            {
                letter = "C-";
            }
            Console.WriteLine("Good Job! But do it better the next time.");
        }
        else if (grade >= 60)
        {
            if (sign >= 7)
            {
                letter = "D+";
            }
            else if (sign >= 4)
            {
                letter = "D";
            }
            else 
            {
                letter = "D-";
            }
            Console.WriteLine("Sorry! but you didn't pass the course. Try harder the next time.");
        }
        else
        {
            letter = "F";
            Console.WriteLine("You didn't pass the course. Try harder the next time.");
        }

        Console.WriteLine($"Your grade is {letter}.");
    }
}