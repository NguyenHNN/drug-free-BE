using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Answer
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string AnswerText { get; set; }
        public bool IsCorrect { get; set; }

        public Question Question { get; set; }
        public ICollection<UserAnswer> UserAnswers { get; set; }
    }
} 