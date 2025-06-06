using System;

namespace Domain.Entities
{
    public class CourseEnrollment
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid CourseId { get; set; }
        public DateTime EnrolledAt { get; set; }
        public string CompleteStatus { get; set; }
        public DateTime? CompleteAt { get; set; }

        public UserAccount User { get; set; }
        public Course Course { get; set; }
    }
} 