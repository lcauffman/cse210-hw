using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
    
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        
        Scriptures scripture = new Scriptures(reference, "Trust in the Lord with all thine heart, and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine("\nPress Enter to CONTINUE, or type quit to EXIT.");
            string userInput = Console.ReadLine();

            if (userInput == "quit")
            {
                break;
            }

            scripture.HideRandomWords(2);
            if (scripture.IsCompletelyHidden())
            {
                Console.Clear();
                Console.WriteLine(scripture.GetDisplayText());
                Console.WriteLine("Completely Hidden! Press Enter to EXIT.");
                Console.ReadLine();
                break;
            }
        
        
        }   
    }
} 

