using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using Monhealth.Application.Models;

namespace Monhealth.Application.Features.Transaction.Queries.GetAllTransactions
{
    public class GetAllTransactionsQuery : IRequest<PageResult<GetAllTransactionsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public GetAllTransactionsQuery(int page, int limit)
        {
            Page = page;
            Limit = limit;
        }
    }
}
