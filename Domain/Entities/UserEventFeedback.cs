using System;

namespace Domain.Entities
{
    public class UserEventFeedback
    {
        public Guid Id { get; set; }
        public Guid ProgramId { get; set; }
        public Guid UserId { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public DateTime SubmittedAt { get; set; }

        public CommunityEvent CommunityEvent { get; set; }
        public UserAccount User { get; set; }
    }
} 