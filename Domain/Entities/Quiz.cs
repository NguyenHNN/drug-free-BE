using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Quiz
    {
        public Guid Id { get; set; }
        public Guid LessonId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsFinalQuiz { get; set; }
        public int TimeLimitMinutes { get; set; }
        public float PassingScore { get; set; }
        public Lesson Lesson { get; set; }
        public ICollection<Question> Questions { get; set; }
        public ICollection<QuizResult> QuizResults { get; set; }
    }
} 