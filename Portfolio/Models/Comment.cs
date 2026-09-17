using System;

namespace Portfolio.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string AuthorName { get; set; }
        public string CommentText { get; set; }
        public DateTime Timestamp { get; set; } = DateTime.Now;
    }
}