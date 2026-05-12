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

        foreach (string s in animation)
        {
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b");
        }
*/
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
        Console.WriteLine();
        Console.WriteLine("Done");
    }
    }
}