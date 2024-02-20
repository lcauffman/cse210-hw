public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"Player's Current Score: {_score}");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("List of Goal Names:");

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal._shortName);
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("List of Goal Details:");

        foreach (Goal goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal()
    {
        Console.Write("Enter goal type (SimpleGoal/ChecklistGoal): ");
        string goalType = Console.ReadLine();

        Console.Write("Enter short name: ");
        string shortName = Console.ReadLine();

        Console.Write("Enter description: ");
        string description = Console.ReadLine();

        Console.Write("Enter points: ");
        int points = int.Parse(Console.ReadLine());

        switch (goalType)
        {
            case "SimpleGoal":
                CreateSimpleGoal(shortName, description, points);
                break;
            case "ChecklistGoal":
                CreateChecklistGoal(shortName, description, points);
                break;
            default:
                Console.WriteLine("Invalid goal type.");
                break;
        }
    }

    private void CreateSimpleGoal(string shortName, string description, int points)
    {
        _goals.Add(new SimpleGoal(shortName, description, points));
        Console.WriteLine($"New SimpleGoal created and added to the list: {shortName}");
    }

    private void CreateChecklistGoal(string shortName, string description, int points)
    {
        Console.Write("Enter target: ");
        int target = int.Parse(Console.ReadLine());

        Console.Write("Enter bonus: ");
        int bonus = int.Parse(Console.ReadLine());

        _goals.Add(new ChecklistGoal(shortName, description, points, target, bonus));
        Console.WriteLine($"New ChecklistGoal created and added to the list: {shortName}");
    }

    public void RecordEvent()
    {
        Console.Write("Enter goal short name to record an event: ");
        string goalShortName = Console.ReadLine();

        Goal goal = _goals.Find(g => g._shortName == goalShortName);

        if (goal != null)
        {
            int pointsEarned = goal.RecordEvent();
            _score += pointsEarned;

            Console.WriteLine($"Event recorded for '{goal._shortName}'. You earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine($"Goal with short name '{goalShortName}' not found.");
        }
    }

    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (Goal goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }

        Console.WriteLine($"Goals saved to file: {filePath}");
    }
    public void LoadGoals(string filePath)
    {
        _goals.Clear();

        using (StreamReader reader = new StreamReader(filePath))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                Goal goal = CreateGoalFromString(line);
                if (goal != null)
                {
                    _goals.Add(goal);
                }
            }
        }
    }



    public void Start()
    {
        while (true)
        {
            Console.WriteLine("===== Goal Manager Menu =====");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create New Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals to File");
            Console.WriteLine("7. Load Goals from File");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice (1-8): ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    Console.Write("Enter file path to save goals: ");
                    string saveFilePath = Console.ReadLine();
                    SaveGoals(saveFilePath);
                    break;
                case "7":
                    Console.Write("Enter file path to load goals: ");
                    string loadFilePath = Console.ReadLine();
                    LoadGoals(loadFilePath);
                    break;
                case "8":
                    Console.WriteLine("Exiting the Goal Manager. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                    break;
            }

            Console.WriteLine(); 
        }
    }


    private static Goal CreateGoalFromString(string details)
    {
        string[] parts = details.Split(':');

        if (parts.Length == 2)
        {
            string[] detailsArray = parts[1].Split(',');

            if (detailsArray.Length >= 3)
            {
                string type = parts[0];
                string name = detailsArray[0];
                string description = detailsArray[1];
                int points = int.Parse(detailsArray[2]);

                switch (type)
                {
                    case "SimpleGoal":
                        return new SimpleGoal(name, description, points);
                    case "ChecklistGoal":
                        if (detailsArray.Length >= 6)
                        {
                            int amountCompleted = int.Parse(detailsArray[3]);
                            int target = int.Parse(detailsArray[4]);
                            int bonus = int.Parse(detailsArray[5]);
                            return new ChecklistGoal(name, description, points, target, bonus);
                        }
                        break;
                }
            }
        }

        return null;
    }
}
