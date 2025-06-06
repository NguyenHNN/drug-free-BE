using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CourseEnrollmentConfiguration : IEntityTypeConfiguration<CourseEnrollment>
    {
        public void Configure(EntityTypeBuilder<CourseEnrollment> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.EnrolledAt).IsRequired();
            builder.Property(e => e.CompleteStatus).HasMaxLength(50);
            builder.Property(e => e.CompleteAt);

            builder.HasOne(e => e.User)
                .WithMany(u => u.CourseEnrollments)
                .HasForeignKey(e => e.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(e => e.Course)
                .WithMany(c => c.CourseEnrollments)
                .HasForeignKey(e => e.CourseId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 