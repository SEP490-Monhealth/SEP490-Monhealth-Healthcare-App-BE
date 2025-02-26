using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Monhealth.Domain.Common;

namespace Monhealth.Application.Features.Expertise.Queries.GetAllExpertises
{
    public class GetAllExpertisesDTO : TimeEntity
    {
        public Guid ExpertiseId { get; set; }
        [JsonPropertyName("name")]
        public string ExpertiseName { get; set; } = string.Empty;
    }
}
