using System;

class ReflectionActivity : Activity
{
    public ReflectionActivity() : base("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience.\nThis will help you recognize the power you have and how you can use it in other aspects of your life.")
    {
    }

    public void Run(string name)
    {
        DisplayStartingMessage();
        AskForDuration();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        Console.Clear();
        Console.WriteLine("Consider the following prompt: ");     
        RandomPrompt();
        Console.WriteLine($"{name}, when you have something in mind press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience: ");
        Console.WriteLine("You may begin in: ");
        _tools.ShowCountdown(5);
        Console.Clear();

        while (DateTime.Now < endTime)
        {
            RandomQuestion();
            _tools.ShowSpinner(40);
            Console.WriteLine();
        }
        
        DisplayEndingMessage();
    }

    public List<string> GetListingPrompts()
    {
        List<string> listingPrompts = new List<string>();
        listingPrompts.Add("Think of a time when you felt proud of yourself.");
        listingPrompts.Add("Think of a time when you overcame a challenge.");
        listingPrompts.Add("Think of a time when you helped someone else.");
        listingPrompts.Add("Think of a time when you learned something new.");
        listingPrompts.Add("Think of a time when you made a difference in someone's life.");
        return listingPrompts;
    }
    public void RandomPrompt()
    {
        Random random = new Random();
        List<string> prompts = GetListingPrompts();
        int index = random.Next(prompts.Count);
        string question = prompts[index];
        Console.WriteLine(" ---" + question + "---");
    }

    public List<string> GetReflectionQuestions()
    {
        List<string> reflectionQuestions = new List<string>();
        reflectionQuestions.Add("How did you feel during this experience?");
        reflectionQuestions.Add("What was the hardest part of this experience?");
        reflectionQuestions.Add("What was the easiest part of this experience?");
        reflectionQuestions.Add("What did you learn from this experience?");
        reflectionQuestions.Add("What would you do differently next time?");
        reflectionQuestions.Add("What would you do the same next time?");
        reflectionQuestions.Add("What did you learn about yourself during this experience?");
        reflectionQuestions.Add("What did you learn about others during this experience?");
        reflectionQuestions.Add("What did you learn about the world during this experience?");
        reflectionQuestions.Add("What did you learn about life during this experience?");
        return reflectionQuestions;
    }

    public void RandomQuestion()
    {
        Random random = new Random();
        List<string> questions = GetReflectionQuestions();
        int index = random.Next(questions.Count);
        string question = questions[index];
        Console.WriteLine(" > " + question);
    }
}
