using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserEventFeedbackConfiguration : IEntityTypeConfiguration<UserEventFeedback>
    {
        public void Configure(EntityTypeBuilder<UserEventFeedback> builder)
        {
            builder.HasKey(fb => fb.Id);
            builder.Property(fb => fb.Comment).HasMaxLength(1000);
            builder.Property(fb => fb.Rating).IsRequired();
            builder.Property(fb => fb.SubmittedAt).IsRequired();
            builder.Property(fb => fb.ProgramId).IsRequired();
            builder.Property(fb => fb.UserId).IsRequired();

            builder.HasOne(fb => fb.CommunityEvent)
                .WithMany(e => e.UserEventFeedbacks)
                .HasForeignKey(fb => fb.ProgramId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(fb => fb.User)
                .WithMany(u => u.UserEventFeedbacks)
                .HasForeignKey(fb => fb.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 