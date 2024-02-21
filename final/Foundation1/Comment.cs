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

    