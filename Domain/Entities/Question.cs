using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Question
    {
        public Guid Id { get; set; }
        public Guid QuizId { get; set; }
        public string Content { get; set; }
        public string QuestionType { get; set; }
        public int QuestionOrder { get; set; }

        public Quiz Quiz { get; set; }
        public ICollection<Answer> Answers { get; set; }
    }
} 