using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class QuizResultConfiguration : IEntityTypeConfiguration<QuizResult>
    {
        public void Configure(EntityTypeBuilder<QuizResult> builder)
        {
            builder.HasKey(qr => qr.ResultId);
            builder.Property(qr => qr.Score).IsRequired();
            builder.Property(qr => qr.AttemptNumber).IsRequired();
            builder.Property(qr => qr.TakenAt).IsRequired();

            builder.HasOne(qr => qr.User)
                .WithMany(u => u.QuizResults)
                .HasForeignKey(qr => qr.UserId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(qr => qr.Quiz)
                .WithMany(q => q.QuizResults)
                .HasForeignKey(qr => qr.QuizId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 