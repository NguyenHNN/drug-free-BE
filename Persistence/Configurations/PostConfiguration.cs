using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Content).IsRequired().HasMaxLength(1000);
            builder.Property(p => p.ImageUrl).HasMaxLength(1000).IsUnicode(false);
            builder.Property(p => p.Published).IsRequired();
            builder.Property(p => p.PublishedAt);

            builder.Property(p => p.AuthorId).IsRequired();
            builder.Property(p => p.CategoryId).IsRequired();

            builder.HasOne(p => p.Author)
                .WithMany(u => u.Posts)
                .HasForeignKey(p => p.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(p => p.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 