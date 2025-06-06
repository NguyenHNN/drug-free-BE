using System;

namespace Domain.Entities
{
    public class UserAnswer
    {
        public Guid Id { get; set; }
        public Guid ResultId { get; set; }
        public Guid AnswerId { get; set; }
        public bool IsSelected { get; set; }
        public bool IsCorrectAnswer { get; set; }

        public QuizResult QuizResult { get; set; }
        public Answer Answer { get; set; }
    }
} 