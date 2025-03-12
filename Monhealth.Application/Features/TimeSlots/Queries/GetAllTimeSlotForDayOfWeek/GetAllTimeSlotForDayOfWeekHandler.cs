﻿using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.TimeSlots.Queries.GetAllTimeSlotForDayOfWeek
{
    public class GetAllTimeSlotForDayOfWeekHandler(ITimeSlotRepository timeSlotRepository) : IRequestHandler<GetAllTimeSlotForDayOfWeekQueries, Dictionary<int, List<string>>>
    {

        private static readonly Dictionary<int, List<TimeOnly>> DefaultTimeSlotRules = new()
    {
        { 0, new List<TimeOnly> { new(8,0), new(9,0), new(10,0), new(11,0), new(14,0), new(15,0), new(16,0) } }, // Sunday
        { 1, new List<TimeOnly> { new(8,0), new(9,0), new(10,0), new(11,0), new(14,0), new(15,0), new(16,0) } }, // Monday
        { 2, new List<TimeOnly> { new(8,0), new(9,0), new(10,0), new(11,0), new(14,0), new(15,0), new(16,0) } }, // Tuesday
        { 3, new List<TimeOnly> { new(8,0), new(9,0), new(10,0), new(11,0), new(14,0), new(15,0), new(16,0) } }, // Wednesday
        { 4, new List<TimeOnly> { new(8,0), new(9,0), new(10,0), new(11,0), new(14,0), new(15,0), new(16,0) } }, // Thursday
        { 5, new List<TimeOnly> { new(9,0), new(10,0), new(11,0), new(14,0), new(15,0) } }, // Friday
        { 6, new List<TimeOnly> { new(9,0), new(10,0), new(11,0) } }  // Saturday
         };

        public async Task<Dictionary<int, List<string>>> Handle(GetAllTimeSlotForDayOfWeekQueries request, CancellationToken cancellationToken)
        {
            var timeslotLists = await timeSlotRepository.GetAllAsync();
            var timeSlotByDays = DefaultTimeSlotRules.ToDictionary(
                    rule => rule.Key,
                    rule => timeslotLists
                    .Where(ts => rule.Value.Contains(ts.StartTime))
                    .OrderBy(ts => ts.StartTime)
                    .Select(ts => ts.StartTime.ToString(@"hh\:mm"))
                    .ToList()

                );
            return timeSlotByDays;
        }
    }
}
