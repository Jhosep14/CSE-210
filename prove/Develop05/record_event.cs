using System;
using System.Collections.Generic;

public class RecordEvent
{
    private List<GoalsSystem> _allGoals;
    
    public RecordEvent(List<GoalsSystem> allGoals)
    {
        _allGoals = allGoals;
    }

    public int EventCompleted()
    {
        Console.Write("Which goal did you complete? ");
        int choice = int.Parse(Console.ReadLine()) - 1;

        GoalsSystem completedGoal = _allGoals[choice];
        return completedGoal.RecordEvent();
    }
}