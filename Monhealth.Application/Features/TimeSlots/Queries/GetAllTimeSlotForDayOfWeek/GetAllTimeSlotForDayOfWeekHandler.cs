using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.TimeSlots.Queries.GetAllTimeSlotForDayOfWeek
{
    public class GetAllTimeSlotForDayOfWeekHandler(ITimeSlotRepository timeSlotRepository)
        : IRequestHandler<GetAllTimeSlotForDayOfWeekQueries, List<DayTimeSlotDto>>
    {
        // Cập nhật Default Rule với cả startTime và endTime
        private static readonly Dictionary<int, List<(TimeOnly StartTime, TimeOnly EndTime)>>
        DefaultTimeSlotRules = new()
        {
            { 0, new List<(TimeOnly, TimeOnly)>
                {
                    (new TimeOnly(8, 0), new TimeOnly(9, 0)),
                    (new TimeOnly(9, 15), new TimeOnly(10, 15)),
                    (new TimeOnly(10, 30), new TimeOnly(11, 30)),
                    (new TimeOnly(13, 45), new TimeOnly(14, 45)),
                    (new TimeOnly(15, 0), new TimeOnly(16, 0)),
                    (new TimeOnly(16, 15), new TimeOnly(17, 15))
                }
            },
            { 1, new List<(TimeOnly, TimeOnly)>
                {
                    (new TimeOnly(8, 0), new TimeOnly(9, 0)),
                    (new TimeOnly(9, 15), new TimeOnly(10, 15)),
                    (new TimeOnly(10, 30), new TimeOnly(11, 30)),
                    (new TimeOnly(13, 45), new TimeOnly(14, 45)),
                    (new TimeOnly(15, 0), new TimeOnly(16, 0)),
                    (new TimeOnly(16, 15), new TimeOnly(17, 15))
                }
            },
            { 2, new List<(TimeOnly, TimeOnly)>
                {
                    (new TimeOnly(8, 0), new TimeOnly(9, 0)),
                    (new TimeOnly(9, 15), new TimeOnly(10, 15)),
                    (new TimeOnly(10, 30), new TimeOnly(11, 30)),
                    (new TimeOnly(13, 45), new TimeOnly(14, 45)),
                    (new TimeOnly(15, 0), new TimeOnly(16, 0)),
                    (new TimeOnly(16, 15), new TimeOnly(17, 15))
                }
            },
            { 3, new List<(TimeOnly, TimeOnly)>
                {
                    (new TimeOnly(8, 0), new TimeOnly(9, 0)),
                    (new TimeOnly(9, 15), new TimeOnly(10, 15)),
                    (new TimeOnly(10, 30), new TimeOnly(11, 30)),
                    (new TimeOnly(13, 45), new TimeOnly(14, 45)),
                    (new TimeOnly(15, 0), new TimeOnly(16, 0)),
                    (new TimeOnly(16, 15), new TimeOnly(17, 15))
                }
            },
            { 4, new List<(TimeOnly, TimeOnly)>
                {
                    (new TimeOnly(8, 0), new TimeOnly(9, 0)),
                    (new TimeOnly(9, 15), new TimeOnly(10, 15)),
                    (new TimeOnly(10, 30), new TimeOnly(11, 30)),
                    (new TimeOnly(13, 45), new TimeOnly(14, 45)),
                    (new TimeOnly(15, 0), new TimeOnly(16, 0)),
                    (new TimeOnly(16, 15), new TimeOnly(17, 15))
                }
            },
            { 5, new List<(TimeOnly, TimeOnly)>
                {
                    (new TimeOnly(9, 15), new TimeOnly(10, 15)),
                    (new TimeOnly(10, 30), new TimeOnly(11, 30)),
                    (new TimeOnly(13, 45), new TimeOnly(14, 45)),
                    (new TimeOnly(15, 0), new TimeOnly(16, 0))
                }
            },
            { 6, new List<(TimeOnly, TimeOnly)>
                {
                    (new TimeOnly(9, 15), new TimeOnly(10, 15)),
                    (new TimeOnly(10, 30), new TimeOnly(11, 30))
                }
            }
        };

        public async Task<List<DayTimeSlotDto>> Handle(GetAllTimeSlotForDayOfWeekQueries request, CancellationToken cancellationToken)
        {
            var timeSlotLists = await timeSlotRepository.GetAllAsync();

            var timeSlotByDays = DefaultTimeSlotRules.Select(rule => new DayTimeSlotDto
            {
                DayOfWeek = rule.Key,
                TimeSlots = timeSlotLists
                    // Lọc các khung giờ từ DB sao cho khớp cặp startTime và endTime dùng rule mặc định
                    .Where(ts => rule.Value.Any(r =>
                        r.StartTime.Equals(ts.StartTime) && r.EndTime.Equals(ts.EndTime)))
                    .OrderBy(ts => ts.StartTime)
                    .Select(ts => $"{ts.StartTime:HH\\:mm} - {ts.EndTime:HH\\:mm}")
                    .ToList()
            }).ToList();

            return timeSlotByDays;
        }
    }
}