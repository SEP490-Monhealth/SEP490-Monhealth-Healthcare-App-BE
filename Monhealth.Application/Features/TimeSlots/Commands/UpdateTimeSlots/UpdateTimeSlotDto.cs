﻿namespace Monhealth.Application.Features.TimeSlots.Commands.UpdateTimeSlots
{
    public class UpdateTimeSlotDto
    {
        public TimeOnly StartTime { get; set; }
        public TimeOnly EndTime { get; set; }
    }
}
