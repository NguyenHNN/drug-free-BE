using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ConsultationAppointmentConfiguration : IEntityTypeConfiguration<ConsultationAppointment>
    {
        public void Configure(EntityTypeBuilder<ConsultationAppointment> builder)
        {
            builder.HasKey(ca => ca.Id);
            builder.Property(ca => ca.Status).HasMaxLength(50);
            builder.Property(ca => ca.AppointmentNote).HasMaxLength(1000);
            builder.Property(ca => ca.MeetLink).HasMaxLength(1000);
            builder.Property(ca => ca.MemberId).IsRequired();

            builder.HasOne(ca => ca.Member)
                .WithMany(u => u.ConsultationAppointments)
                .HasForeignKey(ca => ca.MemberId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 