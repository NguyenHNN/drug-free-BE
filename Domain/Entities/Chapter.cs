using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public Guid CourseId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ChapterOrder { get; set; }
        public Course Course { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
} 