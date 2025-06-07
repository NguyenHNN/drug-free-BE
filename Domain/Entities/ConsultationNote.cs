using System;

namespace Domain.Entities
{
    public class ConsultationNote
    {
        public Guid NoteId { get; set; }
        public Guid AppointmentId { get; set; }
        public string NoteText { get; set; }

        public ConsultationAppointment Appointment { get; set; }
    }
} 