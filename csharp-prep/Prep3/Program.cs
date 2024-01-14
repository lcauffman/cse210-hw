using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is the magic number?");
        string userInput = Console.ReadLine();
        int magic = int.Parse(userInput);
        
        Console.WriteLine("What is your guess?");
        string guess = Console.ReadLine();
        int userGuess = int.Parse(guess);

        if (userGuess == magic)
        {
            Console.WriteLine("Amazing guess, you are correct.");
        }
        else if (userGuess > magic)
        {
            Console.WriteLine("Lower");
        }
        else{
            Console.WriteLine("Higher");
        }

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,51);

        int usersGuess = -1;

        while(usersGuess != magicNumber)
        {
            Console.Write("Guess a number:");
            usersGuess = int.Parse(Console.ReadLine());

            if (magicNumber > usersGuess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < usersGuess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You got it!");
            }
        }
    }
}