using System.Collections.Generic;

namespace Portfolio.Models
{
    public class ProjectDetailsViewModel
    {
        public required Project Project { get; set; }
        public required List<Comment> Comments { get; set; }
        public required Comment NewComment { get; set; }
    }
}