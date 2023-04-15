using FinancialManagerLibrary.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialManager.UI.Controls
{
    public partial class ucLogsForm : UserControl
    {
        public ucLogsForm()
        {
            InitializeComponent();            
        }

        private void ucLogsForm_Load(object sender, EventArgs e)
        {
            LoadLogs();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            LoggingService.GetInstance.ClearLogs();
            LoadLogs();
        }

        private void LoadLogs()
        {
            txtLogs.Text = LoggingService.GetInstance.ReadFromFile();
        }
    }
}
