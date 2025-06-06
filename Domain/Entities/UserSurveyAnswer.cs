using System;

namespace Domain.Entities
{
    public class UserSurveyAnswer
    {
        public Guid Id { get; set; }
        public Guid ResponseId { get; set; }
        public Guid AnswerId { get; set; }
        public bool IsSelected { get; set; }

        public SurveyResponse SurveyResponse { get; set; }
        public SurveyAnswer SurveyAnswer { get; set; }
    }
} 