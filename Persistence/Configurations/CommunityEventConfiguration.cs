using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class CommunityEventConfiguration : IEntityTypeConfiguration<CommunityEvent>
    {
        public void Configure(EntityTypeBuilder<CommunityEvent> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Title).IsRequired().HasMaxLength(200);
            builder.Property(e => e.Description).HasMaxLength(1000);
            builder.Property(e => e.Location).HasMaxLength(200);
            builder.Property(e => e.TargetGroup).HasMaxLength(100);
            builder.Property(e => e.CreatedBy).IsRequired();

            builder.HasOne(e => e.Creator)
                .WithMany(u => u.CommunityEvents)
                .HasForeignKey(e => e.CreatedBy)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 