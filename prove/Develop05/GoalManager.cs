public class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;

    public void Start()
    {
        string userInput = "0";

        Console.Clear();
        DisplayPlayerInfo();

        do
        {
            Console.WriteLine("\nThis is the goal planning and recording App. Please choose a menu option.");
            Console.WriteLine("1. Create a Goal");
            Console.WriteLine("2. List Recorded Goals");
            Console.WriteLine("3. Save a Goal");
            Console.WriteLine("4. Load created Goals");
            Console.WriteLine("5. Record a new Event");
            Console.WriteLine("6. Quit");

            Console.Write("\nEnter an option 1-6: ");
            userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    CreateNewGoal();
                    break;
                case "2":
                    ListGoalDetails();
                    break;
                case "3":
                    SaveGoal();
                    break;
                case "4":
                    LoadGoal();
                    break;
                case "5":
                    RecordNewEvent();
                    break;
                case "6":
                    Console.WriteLine("Exiting the application. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter a number between 1 and 6.");
                    break;
            }

        } while (userInput != "6");
    }

    private void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("1. Simple");
        Console.WriteLine("2. Eternal");
        Console.WriteLine("3. Checklist");
    }


    private void CreateNewGoal()
    {
        Console.WriteLine("Pick a goal type from the following:");
        ListGoalNames();
        Console.Write("> ");
        string userGoal = Console.ReadLine();
        
        Console.WriteLine("Enter the name of your new goal:");
        Console.Write("> ");
        string name = Console.ReadLine();

        Console.WriteLine("Describe your goal:");
        Console.Write("> ");
        string description = Console.ReadLine();

        Console.WriteLine("How many point on a scale from 1-50 is your goal worth ?");
        Console.Write("> ");
        string points = Console.ReadLine();


        if (userGoal == "1")
        {
            SimpleGoals s1 = new SimpleGoals(name, description, points);
            
            _goals.Add(s1);
        }

        else if (userGoal == "2")
        {
            Eternal e1 = new Eternal(name, description, points);
            _goals.Add(e1);
        }

        else if (userGoal == "3")
        {
            Console.WriteLine("Number of times for the goal to be repeated: ");
            Console.Write("> ");

            string goalTarget = Console.ReadLine()

            int target = Int32.Parse(goalTarget);

            Checklist c1 = new Checklist();
            _goals.Add(checklist);


        }





    }

    private void ListGoalDetails()
    {
        // Implement the logic for listing goal details
    }

    private void SaveGoal()
    {
        // Implement the logic for saving a goal
    }

    private void LoadGoal()
    {
        // Implement the logic for loading goals
    }

    private void RecordNewEvent()
    {
        // Implement the logic for recording a new event
    }
}
