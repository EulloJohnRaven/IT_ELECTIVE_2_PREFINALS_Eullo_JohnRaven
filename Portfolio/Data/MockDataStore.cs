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
                Title = "Jeopardy App",
                ShortDescription = "An interactive trivia application.",
                FullDescription = "An interactive Jeopardy game application developed for the IT Elective 2 Prefinal Exam. It features structured questioning and score tracking.",
                GitHubLink = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_BSIT31E1_PREFINAL_EXAM_Eullo_JohnRaven.git",
                ThumbnailUrl = "/images/JeopardyApp.jpg"
            },
            new Project
            {
                Id = 2,
                Title = "Hardware POS",
                ShortDescription = "A point-of-sale system for hardware items.",
                FullDescription = "A comprehensive point-of-sale application designed to manage transactions and inventory for a hardware store environment, developed as part of the IT Elective 2 Midterm.",
                GitHubLink = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Eullo_JohnRaven.git",
                ThumbnailUrl = "/images/HardwarePOS.jpg"
            },
            new Project
            {
                Id = 3,
                Title = "Equipment Borrowing System",
                ShortDescription = "An inventory tracking system for borrowed assets.",
                FullDescription = "A management system designed to track the checkout and return of equipment, ensuring accountability and accurate inventory logs.",
                GitHubLink = "https://github.com/EulloJohnRaven/T_ELECTIVE_2_MIDTERM_EXAM_5_Eullo_JohnRaven.git",
                ThumbnailUrl = "/images/EquipmentBorrowingSystem.jpg"
            },
            new Project
            {
                Id = 4,
                Title = "Playlist Manager",
                ShortDescription = "A multimedia playlist organization tool.",
                FullDescription = "An application built to manage, organize, and track multimedia playlists efficiently, created for the IT Elective 2 Midterm.",
                GitHubLink = "https://github.com/EulloJohnRaven/IT_ELECTIVE_2_MIDTERM_Q2_Eullo_JohnRaven.git",
                ThumbnailUrl = "/images/Playlist.jpg"
            }
        };

        public static List<Comment> Comments = new List<Comment>();
    }
}