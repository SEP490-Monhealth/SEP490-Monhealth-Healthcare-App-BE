using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class GetDailyWaterByUserHandler : IRequestHandler<GetDailyWaterByUserQuery, DailyWaterDTO>
    {
        private readonly IDailyWaterIntakesRepository _dailyWaterIntakesRepository;
        private readonly IMapper _mapper;
        public GetDailyWaterByUserHandler(IDailyWaterIntakesRepository dailyWaterIntakesRepository,
        IMapper mapper)
        {
            _dailyWaterIntakesRepository = dailyWaterIntakesRepository;
            _mapper = mapper;
        }

        public async Task<DailyWaterDTO> Handle(GetDailyWaterByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyWaterIntakesRepository.GetDailyWaterIntakesByUser(request.userId, request.date);

            if (query == null)
            {
                return new DailyWaterDTO
                {
                    DailyWaterIntakeId = Guid.Empty,
                    TotalVolume = 0,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                };
            }

            return _mapper.Map<DailyWaterDTO>(query);
        }
    }
}