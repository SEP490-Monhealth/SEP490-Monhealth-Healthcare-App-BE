using AutoMapper;
using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class GetDailyWaterByUserHandler : IRequestHandler<GetDailyWaterByUserQuery, List<DailyWaterDTO>>
    {
        private readonly IDailyWaterIntakesRepository _dailyWaterIntakesRepository;
        private readonly IMapper _mapper;
        public GetDailyWaterByUserHandler(IDailyWaterIntakesRepository dailyWaterIntakesRepository,
        IMapper mapper)
        {
            _dailyWaterIntakesRepository = dailyWaterIntakesRepository;
            _mapper = mapper;
        }

        public async Task<List<DailyWaterDTO>> Handle(GetDailyWaterByUserQuery request, CancellationToken cancellationToken)
        {
            var query = await _dailyWaterIntakesRepository.GetDaiLyWaterIntakesByUSer(request.userId);
            return _mapper.Map<List<DailyWaterDTO>>(query);
        }
    }
}