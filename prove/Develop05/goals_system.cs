using System;

public abstract class GoalsSystem
{
    private string _name;
    private string _description;
    private int _points;
    protected List<string> _goalDetails = new List<string>();
    protected int _bonusCount;
    protected int _bonusPoints;
    
    public GoalsSystem()
    {

    }

    public string GetName()
    {
        return _name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }


    public List<string> GetGoalDetails()
    {
        _goalDetails.Add(_name);
        _goalDetails.Add(_description);
        _goalDetails.Add(_points.ToString());
        if (this is ChecklistGoal)
        {
            _goalDetails.Add(_bonusCount.ToString());
            _goalDetails.Add(_bonusPoints.ToString());
        }
        return _goalDetails;
    }
    public void GoalQuestion()
    {
        Console.Write("What is the name of your goal? ");
        string name = Console.ReadLine();
        SetName(name);
        Console.Write("What is a short description of your goal? ");
        string description = Console.ReadLine();
        SetDescription(description);
        Console.Write("What is the amount of points you will get for achieving this goal? ");
        string pointsString = Console.ReadLine();
        int points = int.Parse(pointsString);
        SetPoints(points);
    }
    public abstract void AddGoals();

    public abstract string DisplayGoals();

    public abstract string GetSaveDetails();

    public abstract int RecordEvent();


}
