using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class SurveyResponseConfiguration : IEntityTypeConfiguration<SurveyResponse>
    {
        public void Configure(EntityTypeBuilder<SurveyResponse> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.TotalScore).IsRequired();
            builder.Property(r => r.RiskLevel).IsRequired();
            builder.Property(r => r.SuggestedActions).HasMaxLength(1000);
            builder.Property(r => r.SubmittedAt).IsRequired();
            builder.Property(r => r.SurveyId).IsRequired();
            builder.Property(r => r.UserId).IsRequired();

            builder.HasOne(r => r.Survey)
                .WithMany(s => s.SurveyResponses)
                .HasForeignKey(r => r.SurveyId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(r => r.User)
                .WithMany(u => u.SurveyResponses)
                .HasForeignKey(r => r.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 