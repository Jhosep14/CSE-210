using System;
using System.IO;
using System.Collections.Generic;

class ListGoals
{
    private List<GoalsSystem> _allGoals = new List<GoalsSystem>();
    
    public ListGoals(List<GoalsSystem> allGoals)
    {
        _allGoals = allGoals;
    }
    public void DisplayGoals()
    {
        Console.WriteLine("Your goals:");
        Console.WriteLine();
        int index = 1;
        foreach (GoalsSystem goal in _allGoals)
        {
            Console.WriteLine($"{index}. {goal.DisplayGoals()}");
            index++;
        }
        Console.WriteLine();
    }
    
}