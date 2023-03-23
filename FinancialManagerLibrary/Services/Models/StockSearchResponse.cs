using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Services.Models
{
    public class StockSearchResponse
    {
        [JsonPropertyName("bestMatches")]
        public List<bestMatches> bestMatches { get; set; }
    }
}
