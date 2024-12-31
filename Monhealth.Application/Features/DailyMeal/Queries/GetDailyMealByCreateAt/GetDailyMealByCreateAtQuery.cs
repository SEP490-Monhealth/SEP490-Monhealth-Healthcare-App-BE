using MediatR;

namespace Monhealth.Application.Features.DailyMeal.Queries.GetDailyMealByCreateAt
{
    public class GetDailyMealByCreateAtQuery : IRequest<DailyMealByCreateAtDTO>
    {
        public DateTime CreateAt { get; set; }
        // public GetDailyMealByCreateAtQuery(DateTime createAt)
        // {
        //     CreateAt = createAt;
        // }

    }
}