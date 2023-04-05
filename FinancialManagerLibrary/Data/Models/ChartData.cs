using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Data.Models
{
    public class ChartData
    {
        public DateTime Date { get; set; }
        public float Actual { get; set; }
        public float Lower { get; set; }
        public float Forecast { get; set; }
        public float Upper { get; set; }
    }
}
