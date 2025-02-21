using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace Monhealth.Application.Features.Certificate.Queries.GetAllCertificates
{
    public class GetAllCertificatesQuery : IRequest<List<GetAllCertificatesDTO>>
    {
    }
}
