using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class SurveyAnswer
    {
        public Guid Id { get; set; }
        public Guid QuestionId { get; set; }
        public string AnswerText { get; set; }
        public float Score { get; set; }

        public SurveyQuestion SurveyQuestion { get; set; }
        public ICollection<UserSurveyAnswer> UserSurveyAnswers { get; set; }
    }
} 