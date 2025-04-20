using MediatR;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Report.Queries.GetAllReports
{
    public class GetAllReportsQuery : IRequest<PageResult<GetAllReportsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Search { get; set; }
        public StatusReport? Status { get; set; }
    }
}
