using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class SurveyQuestion
    {
        public Guid Id { get; set; }
        public Guid SurveyId { get; set; }
        public string Content { get; set; }
        public int QuestionOrder { get; set; }

        public Survey Survey { get; set; }
        public ICollection<SurveyAnswer> SurveyAnswers { get; set; }
    }
} 