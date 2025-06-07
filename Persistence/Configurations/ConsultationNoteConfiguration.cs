using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class ConsultationNoteConfiguration : IEntityTypeConfiguration<ConsultationNote>
    {
        public void Configure(EntityTypeBuilder<ConsultationNote> builder)
        {
            builder.HasKey(n => n.NoteId);
            builder.Property(n => n.NoteText)
                .HasMaxLength(1000)
                .IsRequired();
            builder.Property(n => n.AppointmentId)
                .IsRequired();

            builder.HasOne(n => n.Appointment)
                .WithMany(a => a.ConsultationNotes)
                .HasForeignKey(n => n.AppointmentId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
} 