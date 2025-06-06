using System;

namespace Domain.Entities
{
    public class QuizResult
    {
        public Guid ResultId { get; set; }
        public Guid QuizId { get; set; }
        public Guid UserId { get; set; }
        public float Score { get; set; }
        public int AttemptNumber { get; set; }
        public DateTime TakenAt { get; set; }

        public Quiz Quiz { get; set; }
        public UserAccount User { get; set; }
    }
} 