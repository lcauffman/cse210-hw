class Comment
{
    public string Commenter { get; private set; }
    public string Text { get; private set; }

    public Comment(string commenter, string text)
    {
        Commenter = commenter;
        Text = text;
    }

    public string GetCommentInfo()
    {
        return $"{Commenter}: {Text}";
    }
}