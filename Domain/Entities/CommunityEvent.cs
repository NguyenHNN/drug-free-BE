using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class CommunityEvent
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public string TargetGroup { get; set; }
        public Guid CreatedBy { get; set; }
        public UserAccount Creator { get; set; }
        public ICollection<EventParticipant> EventParticipants { get; set; }
        public ICollection<UserEventFeedback> UserEventFeedbacks { get; set; }
    }
} 