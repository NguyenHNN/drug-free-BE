using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class SurveyQuestionConfiguration : IEntityTypeConfiguration<SurveyQuestion>
    {
        public void Configure(EntityTypeBuilder<SurveyQuestion> builder)
        {
            builder.HasKey(q => q.Id);
            builder.Property(q => q.Content).IsRequired().HasMaxLength(1000);
            builder.Property(q => q.QuestionOrder).IsRequired();
            builder.Property(q => q.SurveyId).IsRequired();

            builder.HasOne(q => q.Survey)
                .WithMany(s => s.SurveyQuestions)
                .HasForeignKey(q => q.SurveyId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 