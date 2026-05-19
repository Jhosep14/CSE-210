using System;
using System.IO;
using System.Collections.Generic;

public class SimpleGoal : GoalsSystem
{
    private bool _isCompleted = false;

    public override void AddGoals()
    {
        GoalQuestion();
        _goalDetails = GetGoalDetails();
    }

    public void SetIsCompleted(bool status)
    {
        _isCompleted = status;
    }

    public override string DisplayGoals()
    {
        if (_isCompleted)
        {
            return $"[X] {GetName()} - ({GetDescription()})";
        }
        else
        {
            return $"[ ] {GetName()} - ({GetDescription()})";
        }
    }

    public override string GetSaveDetails()
    {
        return $"SimpleGoal,{GetName()},{GetDescription()},{GetPoints()},{_isCompleted}";
    }

    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"Congratulations you have earned {GetPoints()} points!");
        return GetPoints();
    }
}

public class EternalGoal : GoalsSystem
{
    public override void AddGoals()
    {
        GoalQuestion();
        _goalDetails = GetGoalDetails();
    }
    public override string DisplayGoals()
    {
        return $"[ ] {GetName()} - ({GetDescription()})";
    }

    public override string GetSaveDetails()
    {
        return $"EternalGoal,{GetName()},{GetDescription()},{GetPoints()}";
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations you have earned {GetPoints()} points!");
        return GetPoints();
    }
}

public class ChecklistGoal : GoalsSystem
{
    private int _timesCompleted = 0;

    public override void AddGoals()
    {
        GoalQuestion();
        Console.Write("How many times does this goal need to be completed for bonus points? ");
        _bonusCount = int.Parse(Console.ReadLine());
        Console.Write("What is the bonus amount of points for completing this goal? ");
        _bonusPoints = int.Parse(Console.ReadLine());
        _goalDetails = GetGoalDetails();
    }

    public void SetBonusCount(int count)
    {
        _bonusCount = count;
    }

    public void SetBonusPoints(int points)
    {
        _bonusPoints = points;
    }

    public void SetTimesCompleted(int times)
    {
        _timesCompleted = times;
    }

    public override string DisplayGoals()
    {
        if (_timesCompleted >= _bonusCount)
        {
            return $"[X] {GetName()} - ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_bonusCount}";
        }
        else
        {
            return $"[ ] {GetName()} - ({GetDescription()}) -- Currently completed: {_timesCompleted}/{_bonusCount}";
        }
    }

    public override string GetSaveDetails()
    {
        return $"ChecklistGoal,{GetName()},{GetDescription()},{GetPoints()},{_bonusCount},{_bonusPoints},{_timesCompleted}";
    }

    public override int RecordEvent()
    {
        _timesCompleted++;
        int pointsEarned = GetPoints();

        if (_timesCompleted == _bonusCount)
        {
            pointsEarned += _bonusPoints;
        }

        Console.WriteLine($"Congratulations! You have earned {pointsEarned} points.");
        return pointsEarned;
    }
}

public class CreateGoal
{
    public GoalsSystem CreateNewGoal()
    {
        Console.WriteLine("What type of goal do you want to create?");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine();
        Console.Write("Select a goal type from the menu: ");
        string goalType = Console.ReadLine();
        GoalsSystem new_goal = null;
        switch (goalType)
        {
            case "1":
                new_goal = new SimpleGoal();
                new_goal.AddGoals();
                break;
            case "2":
                new_goal = new EternalGoal();
                new_goal.AddGoals();
                break;
            case "3":
                new_goal = new ChecklistGoal();
                new_goal.AddGoals();
                break;
            default:
                Console.WriteLine("Invalid goal type");
                break;
        }
        return new_goal;
    }
}