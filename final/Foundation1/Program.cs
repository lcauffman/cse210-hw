using System;
using System.Collections.Generic;

class Program
{
    
    static List<Video> videos = new List<Video>();

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
            video.DisplayInfo();
            Console.WriteLine();
        }
    }

    //Absraction pertaining to this youtube video display program. Abstraction refers to a process of taking like items, grouping them or using them together to simplify our code.

    //The video class takes everything about the video and handles everything in one group. Organizing and simplifying how to approach this task.

    //The display portion abstracts how we then want to be able to display this information. This is useful because we do not want everything jumbled up.

    //So to drive the point home obviously comments and display are more examples of how this is organized.

    class Video
    {
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        
    }

    public void AddComment(string commenter, string text)
    {
        _comments.Add(new Comment(commenter, text));
    
    }

    public void DisplayInfo()
        {
            Console.WriteLine($"Title: {_title}");
            Console.WriteLine($"Author: {_author}");
            Console.WriteLine($"Length: {_length} seconds");
            Console.WriteLine($"Number of Comments: {_comments.Count}");

            foreach (Comment comment in _comments)
            {
                comment.Display();
            }
        }
    }

    class Comment
    {
        private string _commenter; 
        private string _commentText;

        public Comment(string commenter, string text)
        {
            _commenter = commenter;
            _commentText = text;
        }

        public void Display()
        {
            Console.WriteLine($"  {_commenter}: {_commentText}");
        }
    
    }
}
    