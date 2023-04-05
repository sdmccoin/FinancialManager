using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Models
{
    public class ModelOutput
    {
        public float[] ForecastedClosingValue { get; set; }

        public float[] LowerBoundClosingValue { get; set; }

        public float[] UpperBoundClosingValue { get; set; }
    }
}
