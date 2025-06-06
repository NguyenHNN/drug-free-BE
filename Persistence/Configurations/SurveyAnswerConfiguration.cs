using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class SurveyAnswerConfiguration : IEntityTypeConfiguration<SurveyAnswer>
    {
        public void Configure(EntityTypeBuilder<SurveyAnswer> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.AnswerText).IsRequired().HasMaxLength(500);
            builder.Property(a => a.Score).IsRequired();
            builder.Property(a => a.QuestionId).IsRequired();

            builder.HasOne(a => a.SurveyQuestion)
                .WithMany(q => q.SurveyAnswers)
                .HasForeignKey(a => a.QuestionId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 