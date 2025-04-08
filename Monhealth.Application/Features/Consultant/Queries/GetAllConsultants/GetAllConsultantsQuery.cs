﻿using MediatR;
using Monhealth.Application.Models;
using Monhealth.Domain.Enum;

namespace Monhealth.Application.Features.Consultant.Queries.GetAllConsultants
{
    public class GetAllConsultantsQuery : IRequest<PageResult<GetAllConsultantsDTO>>
    {
        public int Page { get; set; }
        public int Limit { get; set; }
        public string? Expertise { get; set; }
        public string? Search { get; set; }
        public bool? Popular { get; set; }
        public VerificationStatus? Verified { get; set; }
        public bool? Status { get; set; }

        public GetAllConsultantsQuery(int page, int limit, string? expertise, string? search, bool? popular, bool? status, VerificationStatus? verified)
        {
            Page = page;
            Limit = limit;
            Expertise = expertise;
            Search = search;
            Popular = popular;
            Status = status;
            Verified = verified;
        }
    }
}
