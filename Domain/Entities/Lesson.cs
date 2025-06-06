using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Lesson
    {
        public Guid Id { get; set; }
        public Guid ChapterId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string? VideoUrl { get; set; }
        public string Content { get; set; }
        public int LessonOrder { get; set; }
        public bool IsCompleted { get; set; }
        public Chapter Chapter { get; set; }
        public ICollection<Quiz> Quizzes { get; set; }
    }
} 