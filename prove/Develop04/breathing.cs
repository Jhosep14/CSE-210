using System;

class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax and focus on your breathing.\nWe'll guide you through a series of breathing exercises.")
    {
    }

    public void Run(string name)
    {
        DisplayStartingMessage();
        AskForDuration();
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        // The following is one cycle of breathing pattern based on Box Breathing Technique
        int breatheIn = 4;
        int hold = 4;
        int breatheOut = 4;
        while (DateTime.Now < endTime)
        {
            Console.Write($"{name}: Breathe in... ");
            _tools.ShowCountdown(breatheIn);
            Console.Write($"{name}: Now, hold... ");
            _tools.ShowCountdown(hold);
            Console.Write($"{name}: Now, breathe out... ");
            _tools.ShowCountdown(breatheOut);
        }
        DisplayEndingMessage();

        return;
    }
}   