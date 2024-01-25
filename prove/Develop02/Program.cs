using System;

class Program 
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        string userChoice;

        
        //MENU !!!!!
        while (true)
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            userChoice = Console.ReadLine();
            
            //LOOP STARTS HERE !!!!
            
            
            switch (userChoice)
            {
                
                case "1":
                    Entry newEntry = new Entry();
                    theJournal.AddEntry(newEntry);
                    Console.WriteLine("Entry added");
                    break;
                case "2":
                    Console.WriteLine("Past Journal Entries:");
                    theJournal.DisplayAll();
                    break;
                case "3":
                    Console.WriteLine("Enter the filename to load:");
                    string filename = Console.ReadLine();
                    Console.WriteLine("Journal Entries Loading...");
                    theJournal.LoadFromFile(filename);
                    break;
                case "4":
                    Console.WriteLine("Journal Entries Saving...");
                    theJournal.SaveToFile();
                    break;
                case "5":
                    Console.WriteLine("Goodbye");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please choose again.");
                    break;
            }
        }
    }
}
    
