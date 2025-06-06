using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class UserAccount
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Fullname { get; set; }
        public string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Password { get; set; }
        public string? Specialization { get; set; }
        public string? Degree { get; set; }
        public string? ProfilePicture { get; set; }
        public Guid RoleId { get; set; }
        public Role Role { get; set; }
        public ICollection<Post> Posts { get; set; }
        public ICollection<Course> Courses { get; set; }
        public ICollection<QuizResult> QuizResults { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
        public ICollection<Survey> Surveys { get; set; }
        public ICollection<ConsultationAppointment> ConsultationAppointments { get; set; }
        public ICollection<EventParticipant> EventParticipants { get; set; }
        public ICollection<CommunityEvent> CommunityEvents { get; set; }
        public ICollection<UserEventFeedback> UserEventFeedbacks { get; set; }
        public ICollection<SurveyResponse> SurveyResponses { get; set; }
        public ICollection<ConsultantAvailableSlot> ConsultantAvailableSlots { get; set; }
    }
} 