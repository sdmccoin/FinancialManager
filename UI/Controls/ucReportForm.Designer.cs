namespace FinancialManager.UI.Controls
{
    partial class ucReportForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMonthlyIncome = new System.Windows.Forms.Label();
            this.lblYearlyIncome = new System.Windows.Forms.Label();
            this.lblYearlyExpenses = new System.Windows.Forms.Label();
            this.lblMonthlyExpenses = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.wvReportView = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.gbxReportType = new System.Windows.Forms.GroupBox();
            this.rbnInvestment = new System.Windows.Forms.RadioButton();
            this.rbnExpense = new System.Windows.Forms.RadioButton();
            this.rbnIncome = new System.Windows.Forms.RadioButton();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvReportView)).BeginInit();
            this.panel3.SuspendLayout();
            this.gbxReportType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1486, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reporting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(112, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monthly Income:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(112, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Annual Income:";
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonthlyIncome.Location = new System.Drawing.Point(449, 55);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(47, 37);
            this.lblMonthlyIncome.TabIndex = 13;
            this.lblMonthlyIncome.Text = "$0";
            // 
            // lblYearlyIncome
            // 
            this.lblYearlyIncome.AutoSize = true;
            this.lblYearlyIncome.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearlyIncome.Location = new System.Drawing.Point(449, 109);
            this.lblYearlyIncome.Name = "lblYearlyIncome";
            this.lblYearlyIncome.Size = new System.Drawing.Size(47, 37);
            this.lblYearlyIncome.TabIndex = 14;
            this.lblYearlyIncome.Text = "$0";
            // 
            // lblYearlyExpenses
            // 
            this.lblYearlyExpenses.AutoSize = true;
            this.lblYearlyExpenses.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearlyExpenses.Location = new System.Drawing.Point(449, 210);
            this.lblYearlyExpenses.Name = "lblYearlyExpenses";
            this.lblYearlyExpenses.Size = new System.Drawing.Size(47, 37);
            this.lblYearlyExpenses.TabIndex = 14;
            this.lblYearlyExpenses.Text = "$0";
            // 
            // lblMonthlyExpenses
            // 
            this.lblMonthlyExpenses.AutoSize = true;
            this.lblMonthlyExpenses.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonthlyExpenses.Location = new System.Drawing.Point(449, 162);
            this.lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            this.lblMonthlyExpenses.Size = new System.Drawing.Size(47, 37);
            this.lblMonthlyExpenses.TabIndex = 13;
            this.lblMonthlyExpenses.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(112, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 37);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yearly Expenses:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(112, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(236, 37);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monthly Expenses:";
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 65);
            this.panel1.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMonthlyIncome);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblYearlyExpenses);
            this.groupBox1.Controls.Add(this.lblYearlyIncome);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblMonthlyExpenses);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(17, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(577, 320);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quick View";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(846, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 349);
            this.panel2.TabIndex = 18;
            // 
            // wvReportView
            // 
            this.wvReportView.AllowExternalDrop = true;
            this.wvReportView.BackColor = System.Drawing.SystemColors.ControlLight;
            this.wvReportView.CreationProperties = null;
            this.wvReportView.DefaultBackgroundColor = System.Drawing.Color.White;
            this.wvReportView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvReportView.Location = new System.Drawing.Point(0, 0);
            this.wvReportView.Name = "wvReportView";
            this.wvReportView.Size = new System.Drawing.Size(1430, 932);
            this.wvReportView.Source = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.wvReportView.TabIndex = 19;
            this.wvReportView.ZoomFactor = 1D;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.wvReportView);
            this.panel3.Location = new System.Drawing.Point(27, 531);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1434, 936);
            this.panel3.TabIndex = 20;
            // 
            // gbxReportType
            // 
            this.gbxReportType.Controls.Add(this.rbnInvestment);
            this.gbxReportType.Controls.Add(this.rbnExpense);
            this.gbxReportType.Controls.Add(this.rbnIncome);
            this.gbxReportType.Location = new System.Drawing.Point(27, 164);
            this.gbxReportType.Name = "gbxReportType";
            this.gbxReportType.Size = new System.Drawing.Size(283, 268);
            this.gbxReportType.TabIndex = 21;
            this.gbxReportType.TabStop = false;
            this.gbxReportType.Text = "Report Type:";
            // 
            // rbnInvestment
            // 
            this.rbnInvestment.AutoSize = true;
            this.rbnInvestment.Location = new System.Drawing.Point(55, 177);
            this.rbnInvestment.Name = "rbnInvestment";
            this.rbnInvestment.Size = new System.Drawing.Size(202, 45);
            this.rbnInvestment.TabIndex = 2;
            this.rbnInvestment.TabStop = true;
            this.rbnInvestment.Text = "Investment";
            this.rbnInvestment.UseVisualStyleBackColor = true;
            // 
            // rbnExpense
            // 
            this.rbnExpense.AutoSize = true;
            this.rbnExpense.Location = new System.Drawing.Point(55, 119);
            this.rbnExpense.Name = "rbnExpense";
            this.rbnExpense.Size = new System.Drawing.Size(164, 45);
            this.rbnExpense.TabIndex = 1;
            this.rbnExpense.TabStop = true;
            this.rbnExpense.Text = "Expense";
            this.rbnExpense.UseVisualStyleBackColor = true;
            // 
            // rbnIncome
            // 
            this.rbnIncome.AutoSize = true;
            this.rbnIncome.Location = new System.Drawing.Point(55, 65);
            this.rbnIncome.Name = "rbnIncome";
            this.rbnIncome.Size = new System.Drawing.Size(154, 45);
            this.rbnIncome.TabIndex = 0;
            this.rbnIncome.TabStop = true;
            this.rbnIncome.Text = "Income";
            this.rbnIncome.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(472, 207);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(247, 47);
            this.dtpStart.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(381, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 41);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 41);
            this.label5.TabIndex = 25;
            this.label5.Text = "End:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(472, 283);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(247, 47);
            this.dtpEnd.TabIndex = 24;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Location = new System.Drawing.Point(438, 374);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(281, 58);
            this.btnGenerateReport.TabIndex = 26;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // ucReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.gbxReportType);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "ucReportForm";
            this.Size = new System.Drawing.Size(1486, 1493);
            this.Load += new System.EventHandler(this.ucReportForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wvReportView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gbxReportType.ResumeLayout(false);
            this.gbxReportType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblMonthlyIncome;
        private Label lblYearlyIncome;
        private Label lblYearlyExpenses;
        private Label lblMonthlyExpenses;
        private Label label6;
        private Label label7;
        private Panel panel1;
        private GroupBox groupBox1;
        private Panel panel2;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvReportView;
        private Panel panel3;
        private GroupBox gbxReportType;
        private RadioButton rbnExpense;
        private RadioButton rbnIncome;
        private RadioButton rbnInvestment;
        private DateTimePicker dtpStart;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpEnd;
        private Button btnGenerateReport;
    }
}
