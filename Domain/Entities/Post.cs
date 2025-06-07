using System;

namespace Domain.Entities
{
    public class Post
    {
        public Guid Id { get; set; }
        public Guid AuthorId { get; set; }
        public Guid CategoryId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string ImageUrl { get; set; }
        public bool Published { get; set; }
        public DateTime? PublishedAt { get; set; }

        public UserAccount Author { get; set; }
        public Category Category { get; set; }
    }
} 