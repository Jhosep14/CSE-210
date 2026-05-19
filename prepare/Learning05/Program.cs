using System;

class Program
{
    static void Main(string[] args)
    {
        List<string> animation = new List<string>();

        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
/*
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(8);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            string character = animation[i];
            Console.Write(character);
            Thread.Sleep(1000);
            Console.Write("\b");

            i++;

            if (i >= animation.Count)
            {
                i = 0;
            }
        }

        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b");
        }
        Console.WriteLine("Done");

        int seconds = 10;
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b\b  \b\b"); 
        }
*/
        int seconds = 50;
        int animationIndex = 0;
        for (int i = 0; i < seconds; i++)
        {
            string character = animation[animationIndex];
            Console.Write(character);
            Thread.Sleep(500);
            Console.Write("\b");
            
            animationIndex++;
            if (animationIndex >= animation.Count)
            {
                animationIndex = 0;
            }
        }
    }
}