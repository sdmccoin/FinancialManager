using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services.Models
{
    public class bestMatches
    {
        [JsonPropertyName("1. symbol")]
        public string symbol { get; set; }
        [JsonPropertyName("2. name")]
        public string name { get; set; }
        [JsonPropertyName("3. type")]
        public string type { get; set; }
        [JsonPropertyName("4. region")]
        public string region { get; set; }
        [JsonPropertyName("5. marketOpen")]
        public string marketOpen { get; set; }
        [JsonPropertyName("6. marketClose")]
        public string marketClose { get; set; }
        [JsonPropertyName("7. timezone")]
        public string timezone { get; set; }
        [JsonPropertyName("8. currency")]
        public string currency { get; set; }
        [JsonPropertyName("9. matchScore")]
        public string matchScore { get; set; }
    }
}
