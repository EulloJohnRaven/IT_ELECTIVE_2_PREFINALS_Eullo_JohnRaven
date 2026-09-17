namespace Portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string FullDescription { get; set; }
        public string GitHubLink { get; set; }
        public string ThumbnailUrl { get; set; }
    }
}