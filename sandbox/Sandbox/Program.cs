using System;

class Program
{
    static void Main(string[] args)
    {   
        NameList t = new NameList();
        string name = ""; 
        Console.WriteLine("Welcome to the Name List Builder");      
        do 
        {
            Console.Write("What is your name? ");
            name = Console.ReadLine();
            t.addName(name);
            Console.WriteLine("\nInsert 'quit' to exit.\n");
            Console.WriteLine("------------------------------");
        }
        while(name != "quit");
        t.displayList();
    }
}   