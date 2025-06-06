using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserAnswerConfiguration : IEntityTypeConfiguration<UserAnswer>
    {
        public void Configure(EntityTypeBuilder<UserAnswer> builder)
        {
            builder.HasKey(ua => ua.Id);
            builder.Property(ua => ua.IsSelected).IsRequired();
            builder.Property(ua => ua.IsCorrectAnswer).IsRequired();

            builder.HasOne(ua => ua.QuizResult)
                .WithMany()
                .HasForeignKey(ua => ua.ResultId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(ua => ua.Answer)
                .WithMany(a => a.UserAnswers)
                .HasForeignKey(ua => ua.AnswerId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 