using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment("John Doe", "Math");
        Console.WriteLine(assignment1.GetSummary());
        Math math = new Math("Benjamin Franklin", "Calculus", "2.3", "12-28");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Writing writing = new Writing("Mary Waters", "English", "The Roman Empire");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
    
}