using MediatR;
using Monhealth.Application.Contracts.Persistence;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application
{
    public class GetByConsultantListHandler
    (IWithdrawalRepository withdrawalRepository,
    IConsultantRepository consultantRepository)
    : IRequestHandler<GetByConsultantRequest, PageResult<GetByConsultantDTO>>
    {
        public async Task<PageResult<GetByConsultantDTO>> Handle(GetByConsultantRequest request, CancellationToken cancellationToken)
        {
            var queries = await withdrawalRepository
            .GetWithdrawRequestByConsultant(request.ConsultantId, request.Page, request.Limit);
            var withDrawByConsultant = new List<GetByConsultantDTO>();
            foreach (var wd in queries.Items)
            {
                var consultant = await consultantRepository.GetConsultantById(request.ConsultantId);
                GetByConsultantDTO withDrawConsultantDTO = new GetByConsultantDTO(
                    wd.WithdrawalRequestId,
                    wd.ConsultantId,
                    new ConsultantDTO1
                    {
                        AvatarUrl = consultant.AppUser.Avatar,
                        Email = consultant.AppUser.Email,
                        FullName = consultant.AppUser.FullName,
                        PhoneNumber = consultant.AppUser.PhoneNumber
                    },
                    wd.Description,
                    wd.Amount,
                    wd.Status,
                    wd.CreatedAt,
                    wd.UpdatedAt);
                withDrawByConsultant.Add(withDrawConsultantDTO);
            }
            return new PageResult<GetByConsultantDTO>
            {
                CurrentPage = request.Page,
                TotalPages = (int)Math.Ceiling(queries.TotalCount / (double)request.Limit),
                TotalItems = queries.TotalCount,
                Items = withDrawByConsultant
            };

        }
    }
}