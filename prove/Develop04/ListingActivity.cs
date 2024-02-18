namespace Develop04;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _userList = new List<string>();
 
    public ListingActivity(string name, string description) : base(name, description)
    {
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
 
   
 
    public void Run()
    {
        Console.Clear();
        DisplayStartingMessage();
        ShowSpinner(5);
        GetRandomPrompt();
        Console.WriteLine("Return as many responses that come to mind:");
        ShowCountDown(5);
        _userList = GetListFromUser();
 
        Console.WriteLine($"You entered {_userList.Count} responses:");
 
        foreach (string response in _userList)
        {
            Console.WriteLine(response);
        }
 
        DisplayEndingMessage();
    }
 
    void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, _prompts.Count());
        string prompt = _prompts[i];
 
        Console.WriteLine($"----- {prompt} -----");
    }
 
    List<string> GetListFromUser()
    {
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);
 
        List<string> responses = new List<string>();
 
        while (DateTime.Now < futureTime)
        {
            Console.Write(">");
            string response = Console.ReadLine();
            responses.Add(response);
        }
 
        return responses;
    }
}