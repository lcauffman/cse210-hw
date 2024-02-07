public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base(name, description)
    {

    }
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);

        Console.WriteLine("Clear your mind.");
        ShowSpinner(5);

       for (int i = 0; i < _duration; i += 10)
        {
            Console.Write("\n\nBreathe in----- ");
            base.ShowCountDown(4);
            Console.Write("\nExhale----- ");
            base.ShowCountDown(6);
        }
    }
}
        


   
      

