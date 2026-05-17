using System;

class Activity
{
    private string _name;
    private string _description;
    protected int _duration;
    protected Tools _tools;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
        _tools = new Tools();
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine($"Welcome to the {_name}!");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Good job!");
        Console.WriteLine();
        Console.WriteLine($"You have completed the {_name} for {_duration} seconds.");
        Console.WriteLine();
    }
    public void GetReady()
    {
        Console.Write("Get ready...");
        _tools.ShowSpinner(5);
        Console.WriteLine();
    }
    public void AskForDuration()
    {
        Console.Write("How long, in minutes, would you like to practice? (minimum 1 minute): ");
        _duration = int.Parse(Console.ReadLine()) * 60;
        Console.Clear();
        GetReady();
    }
}
