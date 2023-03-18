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
    public partial class ucNotification : UserControl
    {
        public ucNotification()
        {
            InitializeComponent();
        }

        private void ucAlert_Load(object sender, EventArgs e)
        {

        }

        public string AlertCount { get { return lblAlertCount.Text; } set { lblAlertCount.Text = value; } }
        public Label CountLabel { get { return lblAlertCount; } }
        public PictureBox NotificationImage { get { return pictureBox1; } }       
    }
}
