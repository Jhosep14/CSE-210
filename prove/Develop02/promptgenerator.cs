public class promptgenerator
{
    public List<string> _prompts;
    

    public promptgenerator()
    {
        _prompts = new List<string>();
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the most interesting thing I saw or heard today?");
        _prompts.Add("What was the most interesting thing I did today?");
        _prompts.Add("What was the most interesting thing I learned today?");
    }
    public string DisplayRandomPrompt()
    {
        Random rng = new Random();
        int index = rng.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        Console.WriteLine(randomPrompt);
        return randomPrompt;
                
    }
}