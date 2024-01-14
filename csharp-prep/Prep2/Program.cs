using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage:?");
        string userInput = Console.ReadLine();
        int x = int.Parse(userInput);
        int a = 90;
        int b = 80;
        int c = 70;
        int d = 60;
        

        if (x >= a)
        {
            Console.WriteLine("A");
        }
        else if (x >= b)
        {
            Console.WriteLine("B");
        }
        else if (x >= c)
        {
            Console.WriteLine("C");
        }
        else if (x >= d)
        {
            Console.WriteLine("D");
        }
        else 
        {
            Console.WriteLine("F");
        }
        
        Console.WriteLine("What is your grade percentage:?");
        string answer = Console.ReadLine();
        int percent = int.Parse(answer);

        string letter = "";

        if (percent >= 90)
        {
            letter = "A";
        }
        else if (percent >= 80)
        {
            letter = "B";
        }
        else if (percent >= 70)
        {
            letter = "C";
        }
        else if (percent >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (percent >= 70)
        {
            Console.WriteLine("You passed! WOOT!!!!");
        }
        else
        {
            Console.WriteLine("Study harder!");
        }

    }
}