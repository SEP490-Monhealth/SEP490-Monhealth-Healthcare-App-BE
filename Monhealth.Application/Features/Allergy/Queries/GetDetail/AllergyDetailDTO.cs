using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Monhealth.Application.Features.Allergy.Queries.GetDetail
{
    public class AllergyDetailDTO
    {
        [JsonPropertyName("name")]
        public string AllergyName { get; set; } = string.Empty;
        [JsonPropertyName("description")]
        public string AllergyDescription { get; set; } = string.Empty;
    }
}