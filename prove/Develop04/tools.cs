using System;

class Tools
{
    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation.Add("-");
        animation.Add("\\");
        animation.Add("|");
        animation.Add("/");
        
        int animationIndex = 0;
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(animation[animationIndex]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            
            animationIndex++;
            if (animationIndex >= animation.Count)
            {
                animationIndex = 0;
            }
        }
    }

    public void ShowCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine(" ");
    }
}