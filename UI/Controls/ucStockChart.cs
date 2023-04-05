using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FinancialManager.UI.Controls
{
    public partial class ucStockChart : UserControl
    {
        public ucStockChart()
        {
            InitializeComponent();
        }

        private void ucStockChart_Load(object sender, EventArgs e)
        {
            var series = new Series("Finance");

            // Frist parameter is X-Axis and Second is Collection of Y- Axis
            series.Points.DataBindXY(new[] { 2021, 2022, 2022, 2023 }, new[] { 100, 200, 90, 500 });
            chart1.Series.Add(series);
            series.ChartType = SeriesChartType.Line;
        }
    }
}
