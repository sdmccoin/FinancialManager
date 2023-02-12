using FinancialManager.Data.Models;
using FinancialManager.Interfaces;
using FinancialManager.UI.Controllers;
using FinancialManager.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManager.UI.Models
{
    public class InvestmentReport : BaseReport, IReport
    {
        Dictionary<string, string> headerTokenMap;
        StringBuilder report;

        public InvestmentReport() : base(new ReportController())
        {
            report = new StringBuilder();
        }
        public DataTable reportData { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ReportType { get; set; }

        public override string ToString()
        {
            return report.ToString();
        }

        public void BuildReport()
        {
            bool found;
            foreach (string line in File.ReadLines(@"C:/git/src/FinancialManager/FinancialManager/Reports/ReportTemplate.html"))
            {
                found = false;
                // if the token is found in the string, replace it
                foreach (var key in headerTokenMap.Keys)
                {
                    if (line.Contains(key))
                    {
                        if (key == "{Report}")
                        {
                            // Load the body of the report
                            foreach (DataRow dr in reportData.Rows)
                            {
                                report.Append("<tr>");

                                report.Append("<td>");
                                report.Append(dr[0]);
                                report.Append("</td>");
                                report.Append("<td>");
                                report.Append(dr[1]);
                                report.Append("</td>");
                                report.Append("<td>");
                                report.Append(string.Format("{0:C}", dr[2]));
                                report.Append("</td>");

                                report.Append("</tr>");
                            }
                            report.Append("\n");
                        }
                        else
                        {
                            report.Append(line.Replace(key, headerTokenMap[key]) + "\n");
                        }
                        found = true;
                    }
                }

                if (found == false)
                    report.Append(line + "\n");

            }
        }

        public void Generate()
        {
            LoadData();

            // create a map for replacing the template tokens
            headerTokenMap = new Dictionary<string, string>()
            {
                {"{ReportType}",ReportType },
                {"{ReportStart}",StartDate },
                {"{ReportEnd}",EndDate },
                {"{Report}", "ReportBody" }
            };

            BuildReport();
        }

        public void LoadData()
        {
            reportData = new DataTable();
            reportData.Columns.Add("Source", typeof(string));
            reportData.Columns.Add("Address", typeof(string));
            reportData.Columns.Add("Amount", typeof(string));

            foreach (Income entity in Controller.GetIncomeByDateRange(ActiveUser.id))
            {
                reportData.Rows.Add(entity.Source, entity.Address, entity.Amount);
            }
        }
    }
}
