using System.Collections.Generic;

namespace Portfolio.Models
{
    public class ProjectDetailsViewModel
    {
        public Project Project { get; set; }
        public List<Comment> Comments { get; set; }
        public Comment NewComment { get; set; }
    }
}