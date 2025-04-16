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
            PaginatedResult<Domain.WithdrawalRequest> queries = await withdrawalRepository
            .GetWithdrawRequestByConsultant(request.ConsultantId, request.Page, request.Limit);
            Domain.Consultant? consultant = await consultantRepository.GetConsultantById(request.ConsultantId);
            if (consultant is null)
            {
                throw new Exception("");
            }
            List<GetByConsultantDTO> withDrawByConsultant = [..queries.Items.Select(wd => new GetByConsultantDTO(
                    wd.WithdrawalRequestId,
                    wd.ConsultantId,
                    wd.ConsultantBankId,
                    new ConsultantDTO1
                    {
                        AvatarUrl = consultant?.AppUser?.Avatar ?? "",
                        Email = consultant?.AppUser?.Email??"",
                        FullName = consultant?.AppUser?.FullName??"",
                        PhoneNumber = consultant?.AppUser?.PhoneNumber??""
                    },
                    wd.Description,
                    wd.Amount,
                    wd.Status,
                    wd.CreatedAt,
                    wd.UpdatedAt
            ))];
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