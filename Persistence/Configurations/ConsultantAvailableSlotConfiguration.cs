using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ConsultantAvailableSlotConfiguration : IEntityTypeConfiguration<ConsultantAvailableSlot>
    {
        public void Configure(EntityTypeBuilder<ConsultantAvailableSlot> builder)
        {
            builder.HasKey(s => s.Id);
            builder.Property(s => s.WorkDate).IsRequired();
            builder.Property(s => s.IsRecurring).IsRequired();
            builder.Property(s => s.IsBooked).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.ConsultantId).IsRequired();
            builder.Property(s => s.SlotId).IsRequired();
            builder.Property(s => s.ConsultationAppointmentId);

            builder.HasOne(s => s.Consultant)
                .WithMany(u => u.ConsultantAvailableSlots)
                .HasForeignKey(s => s.ConsultantId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.Slot)
                .WithMany(sl => sl.ConsultantAvailableSlots)
                .HasForeignKey(s => s.SlotId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(s => s.ConsultationAppointment)
                .WithMany(ca => ca.ConsultantAvailableSlots)
                .HasForeignKey(s => s.ConsultationAppointmentId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
} 