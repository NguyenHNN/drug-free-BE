using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class EventParticipantConfiguration : IEntityTypeConfiguration<EventParticipant>
    {
        public void Configure(EntityTypeBuilder<EventParticipant> builder)
        {
            builder.HasKey(ep => ep.Id);
            builder.Property(ep => ep.RegisteredAt).IsRequired();
            builder.Property(ep => ep.ProgramId).IsRequired();
            builder.Property(ep => ep.UserId).IsRequired();

            builder.HasOne(ep => ep.CommunityEvent)
                .WithMany(e => e.EventParticipants)
                .HasForeignKey(ep => ep.ProgramId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(ep => ep.User)
                .WithMany(u => u.EventParticipants)
                .HasForeignKey(ep => ep.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 