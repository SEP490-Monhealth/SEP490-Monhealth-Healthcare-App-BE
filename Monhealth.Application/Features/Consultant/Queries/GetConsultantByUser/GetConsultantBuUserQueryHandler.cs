using MediatR;
using Monhealth.Application.Contracts.Persistence;

namespace Monhealth.Application
{
    public class GetConsultantBuUserQueryHandler : IRequestHandler<GetConsultantByUserQuery, GetConsultantByUserDTO>
    {
        private readonly IConsultantRepository _consultantRepository;
        public GetConsultantBuUserQueryHandler(IConsultantRepository consultantRepository)
        {
            _consultantRepository = consultantRepository;

        }
        public async Task<GetConsultantByUserDTO> Handle(GetConsultantByUserQuery request, CancellationToken cancellationToken)
        {
            var userConsultant = await _consultantRepository.GetConsultantByUserId(request.UserId);
            return new GetConsultantByUserDTO
            {
                Avatar =  userConsultant.AppUser.Avatar,
                AverageRating = userConsultant.AverageRating,
                Bio = userConsultant.Bio,
                Experience = userConsultant.Experience,
                ExpertiseName = userConsultant.Expertise.ExpertiseName ,
                FullName = userConsultant.AppUser.FullName,
                RatingCount = userConsultant.RatingCount,
                Status = userConsultant.Status,
                UserId = userConsultant.UserId 
            };
        }
    }
}