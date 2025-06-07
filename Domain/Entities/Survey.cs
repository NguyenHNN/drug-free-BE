using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Survey
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public int MinAge { get; set; }
        public int MaxAge { get; set; }
        public bool Status { get; set; }
        public Guid CreatedBy { get; set; }
        public UserAccount Creator { get; set; }
        public ICollection<SurveyQuestion> SurveyQuestions { get; set; }
        public ICollection<SurveyResponse> SurveyResponses { get; set; }
    }
} 