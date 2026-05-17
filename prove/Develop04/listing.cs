using System;

class ListingActivity : Activity
{
    public ListingActivity() : base("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.")
    {
    }

    public void Run(string name)
    {
        DisplayStartingMessage();
        AskForDuration();
        Console.WriteLine("List as many things as you can in the following area: "); 
        RandomListingQuestion();
        Console.WriteLine($"{name}, when you have something in mind press enter to continue");
        Console.ReadLine();
        Console.Write("You may begin in: ");
        _tools.ShowCountdown(3);
        string answer;
        int count = 0;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            answer = Console.ReadLine();
            if (answer != "")
            {
                count++;
            }
        }
        
        Console.WriteLine();
        Console.WriteLine("You listed " + count + " things!");
        DisplayEndingMessage();
        _tools.ShowSpinner(5);
    }

    public List<string> GetListingQuestions()
    {
        List<string> listingQuestions = new List<string>();
        listingQuestions.Add("When have you felt the holy ghost this month?");
        listingQuestions.Add("When have you felt at peace this month?");
        listingQuestions.Add("When have you felt loved this month?");
        listingQuestions.Add("When have you felt happy this month?");
        listingQuestions.Add("When have you felt grateful this month?");

        return listingQuestions;
    }

    public void RandomListingQuestion()
    {
        Random random = new Random();
        List<string> questions = GetListingQuestions();
        int index = random.Next(questions.Count);
        string question = questions[index];
        Console.WriteLine(" > " + question);
    }
}
