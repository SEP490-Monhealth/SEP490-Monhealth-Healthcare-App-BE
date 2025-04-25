using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class GetDailyWaterByUserHandler : IRequestHandler<GetDailyWaterByUserQuery, DailyWaterDTO>
    {
        private readonly IDailyWaterIntakesRepository _dailyWaterIntakesRepository;
        private readonly IMapper _mapper;
        private readonly IGoalRepository goalRepository;
        private readonly IWaterReminderRepository _waterReminderRepository;

        public GetDailyWaterByUserHandler(IDailyWaterIntakesRepository dailyWaterIntakesRepository,
        IMapper mapper,
        IWaterReminderRepository waterReminderRepository,
        IGoalRepository goalRepository
        )
        {
            _dailyWaterIntakesRepository = dailyWaterIntakesRepository;
            _mapper = mapper;
            _waterReminderRepository = waterReminderRepository;
            this.goalRepository = goalRepository;
        }

        public async Task<DailyWaterDTO> Handle(GetDailyWaterByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyWaterIntakesRepository.GetDailyWaterIntakesByUser(request.userId, request.date);
            var waterReminder = await _waterReminderRepository.GetWaterReminderByUser(request.userId, request.date);
            var goal = await goalRepository.GetGoalByUser(request.userId);
            if (query == null )
            {
                return new DailyWaterDTO
                {
                    DailyWaterIntakeId = Guid.Empty,
                    GoalType = goal.GoalType,
                    TotalVolume = 0,
                    CreatedAt = DateTime.UtcNow,
                    UpdatedAt = DateTime.UtcNow,
                };
            }

            return _mapper.Map<DailyWaterDTO>(query);
        }
    }
}