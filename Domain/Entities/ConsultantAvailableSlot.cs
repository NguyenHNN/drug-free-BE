using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class ConsultantAvailableSlot
    {
        public Guid Id { get; set; }
        public Guid ConsultantId { get; set; }
        public Guid SlotId { get; set; }
        public Guid? ConsultationAppointmentId { get; set; }
        public DateTime WorkDate { get; set; }
        public bool IsRecurring { get; set; }
        public bool IsBooked { get; set; }
        public int Status { get; set; }

        public UserAccount Consultant { get; set; }
        public Slot Slot { get; set; }
        public ConsultationAppointment? ConsultationAppointment { get; set; }
    }
} 