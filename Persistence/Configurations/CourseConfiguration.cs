using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.HasKey(c => c.CourseId);
            builder.Property(c => c.Title).IsRequired().HasMaxLength(255);
            builder.Property(c => c.Description).HasMaxLength(500);
            builder.Property(c => c.Image_Url).HasMaxLength(1000).IsUnicode(false);
            builder.Property(c => c.CourseType).HasMaxLength(50).IsUnicode(false);
            builder.Property(c => c.AgeGroup).IsRequired();
            builder.Property(c => c.AuthorId).IsRequired();

            builder.HasOne(c => c.Author)
                .WithMany(u => u.Courses)
                .HasForeignKey(c => c.AuthorId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 