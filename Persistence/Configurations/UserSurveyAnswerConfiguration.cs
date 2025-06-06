using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class UserSurveyAnswerConfiguration : IEntityTypeConfiguration<UserSurveyAnswer>
    {
        public void Configure(EntityTypeBuilder<UserSurveyAnswer> builder)
        {
            builder.HasKey(usa => usa.Id);
            builder.Property(usa => usa.IsSelected).IsRequired();

            builder.HasOne(usa => usa.SurveyResponse)
                .WithMany(sr => sr.UserSurveyAnswers)
                .HasForeignKey(usa => usa.ResponseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(usa => usa.SurveyAnswer)
                .WithMany(sa => sa.UserSurveyAnswers)
                .HasForeignKey(usa => usa.AnswerId)
                .OnDelete(DeleteBehavior.Restrict); // Changed to Restrict to avoid multiple cascade paths
        }
    }
} 