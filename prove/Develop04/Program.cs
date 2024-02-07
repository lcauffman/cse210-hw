using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {

            Console.WriteLine("Welcome to the Mindfulness Program");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine(" 1. Start the breathing activity");
            Console.WriteLine(" 2. Start the reflecting activity");
            Console.WriteLine(" 3. Start the listing activity");
            Console.WriteLine(" 4. Quit");

            Console.WriteLine("Enter your choice (1-4): ");

            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    BreathingActivity breathing = new BreathingActivity("Breathing", "This activity will calm your mind and allow you to focus.\n");
                    breathing.DisplayStartingMessage();
                    breathing.Run();
                    breathing.DisplayEndingMessage();
                    break;

                case "2":
                    ReflectingActivity reflecting = new ReflectingActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
                    reflecting.DisplayStartingMessage();
                    reflecting.Run();
                    reflecting.DisplayEndingMessage();
                    break;

                case "3":
                    ListingActivity listing = new ListingActivity("Listing", "This activity will help you reflect on the good things your life by having you list as many things as you can in a certain area.\n");
                    listing.DisplayStartingMessage();
                    listing.Run();
                    listing.DisplayEndingMessage();
                    break;

                case "4":
                    Console.WriteLine("Thank you for using the Mindfulness Program");
                    return; 

                default:
                    Console.WriteLine("Invalid input. Please enter a valid option (1-4).");
                    break;
            }

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}