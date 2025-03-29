using MediatR;
using Monhealth.Application.Models.Paging;
using Monhealth.Core;

namespace Monhealth.Application.Features.Payment.Queries.GetALL
{
    public class GetPaymentListQuery : IRequest<PageResult<PaymentDTO>>
    {
        public int page { get; set; }
        public int limit { get; set; }
        public string search { get; set; } = string.Empty;
        public PaymentStatus? status { get; set; }
        public GetPaymentListQuery(int Page, int Limit, string Search, PaymentStatus? Status)
        {
            page = Page;
            limit = Limit;
            search = Search;
            status = Status;
        }
    }
}