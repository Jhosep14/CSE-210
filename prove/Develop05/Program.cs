using System;

class Program
{
    static void Main(string[] args)
    {
        List<GoalsSystem> MasterGoalList = new List<GoalsSystem>();
        Console.WriteLine("Welcome to the Goal Tracker Program!");
        Console.WriteLine("----------------------------------------");
        string choice = "";
        int totalPoints = 0;
        int totalEventsCompleted = 0;
        do
        {
            int currentLevel = (totalEventsCompleted / 10) + 1;
            Console.WriteLine($"*** Current Level: {currentLevel} ***");
            Console.WriteLine($"Total Points: {totalPoints}");
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    Console.Clear();
                    CreateGoal createGoal = new CreateGoal();
                    GoalsSystem new_goal = createGoal.CreateNewGoal();
                    if (new_goal != null)
                    {
                        MasterGoalList.Add(new_goal);
                    }
                    break;
                case "2":
                    Console.Clear();
                    ListGoals listGoals = new ListGoals(MasterGoalList);
                    listGoals.DisplayGoals();
                    Console.WriteLine();
                    break;
                case "3":
                    Console.Clear();
                    SaveGoals saveGoals = new SaveGoals(MasterGoalList);
                    saveGoals.Save();
                    MasterGoalList.Clear(); 
                    break;
                case "4":
                    Console.Clear();
                    LoadGoals loadGoals = new LoadGoals(MasterGoalList);
                    loadGoals.Load();
                    Console.WriteLine();
                    break;
                case "5":
                    Console.Clear();
                    RecordEvent recordEvent = new RecordEvent(MasterGoalList);
                    totalPoints += recordEvent.EventCompleted();
                    totalEventsCompleted++;
                    Console.WriteLine();
                    break;
                case "6":
                    Console.Clear();
                    Console.WriteLine();
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        } while (choice != "6");
        Console.WriteLine("Thank you for using the Goal Tracker Program!");
    }
}