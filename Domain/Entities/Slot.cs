using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Slot
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public ICollection<ConsultantAvailableSlot> ConsultantAvailableSlots { get; set; }
    }
} 