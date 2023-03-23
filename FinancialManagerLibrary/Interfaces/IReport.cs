using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagerLibrary.Interfaces
{
    public interface IReport
    {
        DataTable reportData { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ReportType { get; set; }
        public string ReportFrequency { get; set; }
        void LoadData();
        void BuildReport();
        void Generate();
    }
}
