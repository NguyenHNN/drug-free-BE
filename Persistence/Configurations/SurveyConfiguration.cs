using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class SurveyConfiguration : IEntityTypeConfiguration<Survey>
    {
        public void Configure(EntityTypeBuilder<Survey> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.Title).IsRequired().HasMaxLength(255);
            builder.Property(s => s.Description).HasMaxLength(1000);
            builder.Property(s => s.Type).HasMaxLength(50);
             builder.Property(s => s.MinAge).IsRequired();
            builder.Property(s => s.MaxAge).IsRequired();
            builder.Property(s => s.Status);
            builder.Property(s => s.CreatedBy).IsRequired();
            builder.HasCheckConstraint("CK_Survey_AgeRange", "MinAge < MaxAge");
            builder.HasOne(s => s.Creator)
                .WithMany(u => u.Surveys)
                .HasForeignKey(s => s.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 