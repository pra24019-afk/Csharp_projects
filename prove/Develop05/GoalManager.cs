using System;

public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score = 0;

    public void DisplayGoals()
    {
        int i = 1;
        foreach (Goal goal in _goals)
        {
            Console.WriteLine($"{i}. {goal.GetDetailsString()}");
            i++;
        }
    }

    public void DisplayScore()
    {
        Console.WriteLine($"Score: {_score}");
    }

    public void CreateGoal()
    {
        Console.WriteLine("Types of Goals:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");

        Console.Write("Which type? ");
        string type = Console.ReadLine();

        Console.Write("Goal name: ");
        string name = Console.ReadLine();

        Console.Write("Description: ");
        string description = Console.ReadLine();

        Console.Write("Points: ");
        int points = int.Parse(Console.ReadLine());

        if (type == "1")
        {
            SimpleGoal goal = new SimpleGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (type == "2")
        {
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }

        else if (type == "3")
        {
            Console.Write("How many times required? ");
            int target = int.Parse(Console.ReadLine());

            Console.Write("Bonus points: ");
            int bonus = int.Parse(Console.ReadLine());

            ChecklistGoal goal = new ChecklistGoal(name, description, points, target, bonus);
            _goals.Add(goal);
        }
    }

    public void RecordEvent()
    {
        DisplayGoals();

        Console.Write("Which goal did you accomplish? ");
        int choice = int.Parse(Console.ReadLine());

        int index = choice - 1;

        int points = _goals[index].RecordEvent();

        _score += points;

        Console.WriteLine($"You earned {points} points!");
    }

    public void SaveGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        using (StreamWriter output = new StreamWriter(file))
        {
            output.WriteLine(_score);

            foreach (Goal goal in _goals)
            {
                output.WriteLine(goal.GetStringRepresentation());
            }
        }
    }

    public void LoadGoals()
    {
        Console.Write("File name: ");
        string file = Console.ReadLine();

        string[] lines = File.ReadAllLines(file);

        _score = int.Parse(lines[0]);

        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string line = lines[i];
            string[] parts = line.Split("|");

            if (parts[0] == "SimpleGoal")
            {
                _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3])));
            }

            else if (parts[0] == "EternalGoal")
            {
                _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
            }

            else if (parts[0] == "ChecklistGoal")
            {
                _goals.Add(new ChecklistGoal(
                    parts[1],
                    parts[2],
                    int.Parse(parts[3]),
                    int.Parse(parts[5]),
                    int.Parse(parts[6])
                ));
            }
        }
    }
}
