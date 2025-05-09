﻿using Monhealth.Domain.Common;
using Monhealth.Domain.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Monhealth.Domain
{
    public class Schedule : TimeEntity
    {
        [Key]
        public Guid ScheduleId { get; set; }
        public Guid ConsultantId { get; set; }
        public ScheduleType ScheduleType { get; set; }
        public RecurringDay? RecurringDay { get; set; }
        public DateOnly? SpecificDate { get; set; }

        [ForeignKey(nameof(ConsultantId))]
        public Consultant Consultant { get; set; }
        public ICollection<ScheduleTimeSlot>? ScheduleTimeSlots { get; set; }
    }
}
