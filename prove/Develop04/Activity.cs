namespace Develop04;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    protected Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome user to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Excellent Work!!");
        Console.WriteLine();

        Console.WriteLine($"Now completed {_duration} seconds of the {_name}");
        ShowSpinner(10);
    }
    
    protected void ShowSpinner(int seconds)
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
 
    protected void ShowCountDown(int seconds)
    {
        for (int i = 0; i < seconds; i++)
        {
            Console.Write(seconds - i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
    

