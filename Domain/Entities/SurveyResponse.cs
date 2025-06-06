using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class SurveyResponse
    {
        public Guid Id { get; set; }
        public Guid SurveyId { get; set; }
        public Guid UserId { get; set; }
        public float TotalScore { get; set; }
        public float RiskLevel { get; set; }
        public string SuggestedActions { get; set; }
        public DateTime SubmittedAt { get; set; }

        public Survey Survey { get; set; }
        public UserAccount User { get; set; }
        public ICollection<UserSurveyAnswer> UserSurveyAnswers { get; set; }
    }
} 