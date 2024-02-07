using System;

class ReflectingActivity : Activity
{

    List<string> _prompts = new List<string>();

    List<string> _questions = new List<string>();

    public ReflectingActivity(string name, string description) : base(name, description)
    {
        
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        
        
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    
    }
    //RUN *******
    public void Run()
    
    {
    
        Console.Clear();

        
        Console.WriteLine("Clear your mind.");
        base.ShowSpinner(5);
   
        DisplayPrompt();
        Console.WriteLine($"\n When you have something in your mind, press ENTER");
        string entry = Console.ReadLine();
    
        if (string.IsNullOrWhiteSpace(entry))
        {
            
            Console.WriteLine("Think of experiences that are related to these questions.");
            Console.Write("Please Begin in: ");
            base.ShowCountDown(5);

            for (int i = 0; i < _duration; i+= 10)
            
            {
                DisplayQuestion();
            }
        }
    }
    //RANDOM PROMPT ******
    public string GetRandomPrompt()
    
    {
        
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        
        return _prompts[i];
    }
    //RANDOM QUESTIONS ******
    
    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(0, _questions.Count());

        return _questions[i];
    }
    //DISPLAY PROMPT ******

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine($"----- {prompt} -----");
    }
    //DISPLAY QUESTION ******

    public void DisplayQuestion()
    
    {
    
        Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(_duration);


        while (DateTime.Now < futureTime)
        {
            string question = GetRandomQuestion();
            Console.WriteLine();
            Console.Write(question);
            ShowSpinner(10);
        }
    }

    
    
}