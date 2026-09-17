using System.Collections.Generic;
using Portfolio.Models;

namespace Portfolio.Data
{
    public static class MockDataStore
    {
        public static List<Project> Projects = new List<Project>
        {
            new Project
            {
                Id = 1,
                Title = "Sales Management System",
                ShortDescription = "VBA and Access-based inventory system.",
                FullDescription = "A complete sales tracking system utilizing SQL indexing for performance optimization.",
                GitHubLink = "https://github.com/yourusername/sales-system",
                ThumbnailUrl = "/images/sales.png"
            },
            new Project
            {
                Id = 2,
                Title = "Smart IoT Traffic Controller",
                ShortDescription = "Arduino-based logic circuit.",
                FullDescription = "An embedded systems project featuring pedestrian signals and automated timing.",
                GitHubLink = "https://github.com/yourusername/traffic-controller",
                ThumbnailUrl = "/images/traffic.png"
            }
        };

        public static List<Comment> Comments = new List<Comment>();
    }
}