using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static List<Video> videos = new List<Video>();

    static void DisplayVideoInfo(Video video)
    {
        Console.WriteLine($"Title: {video.Title}");
        Console.WriteLine($"Author: {video.Author}");
        Console.WriteLine($"Length: {video.Length}");
        Console.WriteLine("Comments:");
        foreach (Comment comment in video.Comments)
        {
            Console.WriteLine($"- {comment.Commenter}: {comment.Text}");
        }
        Console.WriteLine();
    }

    static void Main(string[] args)
    {
        Video v1 = new Video("Rudolph The Red Nose Reindeer", "Miss Anne", 7000);
        v1.AddComment("Bob", "He has a shiny nose!");
        v1.AddComment("Sampson", "We want Christmas back.");

        Video v2 = new Video("Sandy Beaches", "Tim Toolman", 800);
        v2.AddComment("Charlie", "I need some sand.");
        v2.AddComment("Sam", "Ocean Blues.");

        Video v3 = new Video("Rich People Problems", "Elon Tusk", 10000);
        v3.AddComment("Mark", "My boat is too big.");
        v3.AddComment("Jeff", "I shave my head.");

        videos.Add(v1);
        videos.Add(v2);
        videos.Add(v3);

        foreach (Video video in videos)
        {
            DisplayVideoInfo(video);
        }
    }
}