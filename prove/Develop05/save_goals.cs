using System;
using System.IO;
using System.Collections.Generic;

public class SaveGoals
{
    private string _filename;
    private List<GoalsSystem> _allGoals;

    public SaveGoals(List<GoalsSystem> allGoals)
    {
        _allGoals = allGoals;
    }

    public string GetFilename()
    {
        Console.Write("What is the name of the file you want to save your goals to? ");
        return Console.ReadLine();
    }

    public void Save()
    {
        _filename = GetFilename();
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (GoalsSystem goal in _allGoals)
            {
                outputFile.WriteLine(goal.GetSaveDetails());
            }
        }
    }
}
