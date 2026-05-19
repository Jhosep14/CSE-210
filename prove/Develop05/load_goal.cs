using System;
using System.IO;
using System.Collections.Generic;

public class LoadGoals
{
    private List<GoalsSystem> _allGoals;
    
    public LoadGoals(List<GoalsSystem> allGoals)
    {
        _allGoals = allGoals;
    }

    public void Load()
    {
        Console.Write("Enter the filename to load goals from: ");
        string filename = Console.ReadLine();
        
        string[] allLines = File.ReadAllLines(filename);

        foreach (string line in allLines)
        {
            string[] parts = line.Split(",");
            string type = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if(type == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal();
                goal.SetName(name);
                goal.SetDescription(description);
                goal.SetPoints(points);
                goal.SetIsCompleted(bool.Parse(parts[4]));
                _allGoals.Add(goal);

            }
            else if(type == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal();
                goal.SetName(name);
                goal.SetDescription(description);
                goal.SetPoints(points);
                goal.SetBonusCount(int.Parse(parts[4]));
                goal.SetBonusPoints(int.Parse(parts[5]));
                goal.SetTimesCompleted(int.Parse(parts[6]));
                
                _allGoals.Add(goal);

            }
            else if(type == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal();
                goal.SetName(name);
                goal.SetDescription(description);
                goal.SetPoints(points);
                _allGoals.Add(goal);
            }   
        }
    }
}