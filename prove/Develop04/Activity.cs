public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;
    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Prepare for {_name} Activity.\n");
        Console.WriteLine(_description);
        Console.WriteLine("Enter duration of time(SECONDS) for the activity:");
        string input = Console.ReadLine();
        _duration = int.Parse(input);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine("\nCongratulations\n");
        Console.WriteLine($"\n{_duration} seconds of {_name} complete.");
    }

    public void ShowSpinner(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write("|");
            Thread.Sleep(250);
            
            Console.Write("\b \b");

            
            Console.Write("/");
            Thread.Sleep(250);
            
            Console.Write("\b \b"); 

            
            Console.Write("-");
            Thread.Sleep(250);
            
            Console.Write("\b \b"); 

            
            Console.Write("\\");
            Thread.Sleep(250);
            
            Console.Write("\b \b");
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(seconds - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}