using System;

class Program
{

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string UserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int GetNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void GetUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter your birthday (year only): ");
        birthYear = int.Parse(Console.ReadLine());
    }
    static int Square(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult()
    {
        string name = UserName();
        int number = GetNumber();
        GetUserBirthYear(out int birthYear);
        Console.WriteLine(name + ", the square of your number is " + Square(number));
        Console.WriteLine(name + " you will turn " +(DateTime.Now.Year - birthYear));
    }

    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        DisplayResult();
    }
}