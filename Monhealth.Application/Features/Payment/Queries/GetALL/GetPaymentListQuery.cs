using MediatR;
using Monhealth.Application.Models.Paging;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class GetPaymentListQuery : IRequest<PageResult<PaymentDTO>>
    {
        public int page { get; set; }
        public int limit { get; set; }
        public string search { get; set; } = string.Empty;
        public GetPaymentListQuery(int Page , int Limit, string Search)
        {
            page = Page;
            limit = Limit;
            search = Search;
        }
    }
}