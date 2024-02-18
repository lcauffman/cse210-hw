namespace Develop04;

public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {
    
    }
    public void Run()
    {

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("");
            Console.Write("Breath in...");
            ShowCountDown(4);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.Write("Breath out...");
            ShowCountDown(6);
        }
        
    }
}

//Reach end time in seconds while loops now, future time
