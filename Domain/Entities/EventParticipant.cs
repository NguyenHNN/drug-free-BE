using System;

namespace Domain.Entities
{
    public class EventParticipant
    {
        public Guid Id { get; set; }
        public Guid ProgramId { get; set; }
        public Guid UserId { get; set; }
        public DateTime RegisteredAt { get; set; }

        public CommunityEvent CommunityEvent { get; set; }
        public UserAccount User { get; set; }
    }
} 