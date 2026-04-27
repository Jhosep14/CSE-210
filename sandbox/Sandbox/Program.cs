using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        
        Person p = new Person();
        p._firstName = "Mary";
        p._lastName = "Jane";
        p.ShowWesternName();
        p.ShowEasternName();
    }
}

