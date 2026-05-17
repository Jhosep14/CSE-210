using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        string name = "";
        do
        {
            Console.WriteLine("Welcome to the Mindfulness App!");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Quit");
            Console.WriteLine();
            Console.Write("What would you like to do? ");
            choice = Console.ReadLine();
            Console.Write("One question before we start: What is your name? ");
            name = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Run(name);
                    Console.WriteLine();
                    break;
                case "2":
                    Console.Clear();
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Run(name);
                    Console.WriteLine();
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Run(name);
                    Console.WriteLine();
                    break;
                case "4":
                    Console.WriteLine("You chose Quit");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != "4");
        Console.Clear();
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Thank you for using the Mindfulness App!");
        Console.WriteLine("---------------------------------");
    }
}