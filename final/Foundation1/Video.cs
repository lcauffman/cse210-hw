class Video
{
    public string Title { get; private set; }
    public string Author { get; private set; }
    public int Length { get; private set; }
    public List<Comment> Comments { get; private set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }

    public void AddComment(string commenter, string comment)
    {
        Comments.Add(new Comment(commenter, comment));
    }

    public string GetInfoAsString()
    {
        return $"Title: {Title}\nAuthor: {Author}\nViews: {Length}\nComments: {string.Join(", ", Comments.Select(c => c.GetCommentInfo()))}";
    }
}
