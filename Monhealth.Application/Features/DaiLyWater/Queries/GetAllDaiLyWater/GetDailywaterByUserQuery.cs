using MediatR;
using Monhealth.Domain;

namespace Monhealth.Application.Features.DaiLyWater.Queries.GetAllDaiLyWater
{
    public class GetDailywaterByUserQuery : IRequest<List<DailyWaterDTO>>
    {
        public Guid userId { get; set; }
        public GetDailywaterByUserQuery(Guid UserId)
        { 
             userId = UserId;
        }

    }
}