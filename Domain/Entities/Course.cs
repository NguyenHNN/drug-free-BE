using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Course
    {
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image_Url { get; set; }
        public string CourseType { get; set; }
        public int AgeGroup { get; set; }
        public Guid AuthorId { get; set; }
        public UserAccount Author { get; set; }
        public ICollection<Chapter> Chapters { get; set; }
        public ICollection<CourseEnrollment> CourseEnrollments { get; set; }
    }
} 