using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application.Features.UserFood.Queries
{
    public class UserFoodQueryHandler : IRequestHandler<UserFoodQuery, List<UserFoodDTO>>
    {
        private readonly IUserFoodRepository _userFoodRepository;
        public UserFoodQueryHandler(IUserFoodRepository userFoodRepository)
        {
            _userFoodRepository = userFoodRepository;
        }

        public async Task<List<UserFoodDTO>> Handle(UserFoodQuery request, CancellationToken cancellationToken)
        {
            var query = await _userFoodRepository.GetAllAsync();
            return query.Select(x => new UserFoodDTO
            {
                Allergies = x.Allergies,
                Categories = x.Categories,
                UserFoodId = x.UserFoodId,
                UserId = x.UserId
            }).ToList();
        }
    }
}