using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ConsultationAppointment
    {
        public Guid Id { get; set; }
        public Guid MemberId { get; set; }
        public string Status { get; set; }
        public string AppointmentNote { get; set; }
        public string MeetLink { get; set; }

        public UserAccount Member { get; set; }
        public ICollection<ConsultationNote> ConsultationNotes { get; set; }
        public ICollection<ConsultantAvailableSlot> ConsultantAvailableSlots { get; set; }
    }
} 