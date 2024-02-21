class Program
{
    static void Main()
    {
        
        Address eventAddress = new Address("123 Expensive Dr.", "Los Angeles", "California", "679827");
        Lecture lectureEvent = new Lecture("Gym Members", "Gym Education Training", DateTime.Now, "11:00 PM", eventAddress, "Dwayne Johnson", 50);
        Reception receptionEvent = new Reception("Speed Dating", "Casual dating event", DateTime.Now.AddDays(7), "6:00 PM", eventAddress, "rsvp@example.com");
        OutdoorGathering outdoorEvent = new OutdoorGathering("Swimming & BBQ", "Outdoor gathering", DateTime.Now.AddMonths(2), "1:00 PM", eventAddress, "Bring swimsuit & a dish to share.");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(lectureEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(lectureEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(lectureEvent.GetShortDescription());

        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(receptionEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(receptionEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(receptionEvent.GetShortDescription());

        Console.WriteLine("\n---------------------------\n");

        Console.WriteLine("Standard Details:");
        Console.WriteLine(outdoorEvent.GetStandardDetails());
        Console.WriteLine("\nFull Details:");
        Console.WriteLine(outdoorEvent.GetFullDetails());
        Console.WriteLine("\nShort Description:");
        Console.WriteLine(outdoorEvent.GetShortDescription());
    }
}