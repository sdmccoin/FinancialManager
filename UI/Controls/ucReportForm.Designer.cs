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
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvReportView)).BeginInit();
            this.panel3.SuspendLayout();
            this.gbxReportType.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1486, 53);
            this.label1.TabIndex = 10;
            this.label1.Text = "Reports";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(100, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monthly Income:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(100, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 31);
            this.label3.TabIndex = 1;
            this.label3.Text = "Annual Income:";
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonthlyIncome.Location = new System.Drawing.Point(437, 31);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(41, 31);
            this.lblMonthlyIncome.TabIndex = 13;
            this.lblMonthlyIncome.Text = "$0";
            // 
            // lblYearlyIncome
            // 
            this.lblYearlyIncome.AutoSize = true;
            this.lblYearlyIncome.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearlyIncome.Location = new System.Drawing.Point(437, 85);
            this.lblYearlyIncome.Name = "lblYearlyIncome";
            this.lblYearlyIncome.Size = new System.Drawing.Size(41, 31);
            this.lblYearlyIncome.TabIndex = 14;
            this.lblYearlyIncome.Text = "$0";
            // 
            // lblYearlyExpenses
            // 
            this.lblYearlyExpenses.AutoSize = true;
            this.lblYearlyExpenses.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYearlyExpenses.Location = new System.Drawing.Point(437, 186);
            this.lblYearlyExpenses.Name = "lblYearlyExpenses";
            this.lblYearlyExpenses.Size = new System.Drawing.Size(41, 31);
            this.lblYearlyExpenses.TabIndex = 14;
            this.lblYearlyExpenses.Text = "$0";
            // 
            // lblMonthlyExpenses
            // 
            this.lblMonthlyExpenses.AutoSize = true;
            this.lblMonthlyExpenses.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMonthlyExpenses.Location = new System.Drawing.Point(437, 138);
            this.lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            this.lblMonthlyExpenses.Size = new System.Drawing.Size(41, 31);
            this.lblMonthlyExpenses.TabIndex = 13;
            this.lblMonthlyExpenses.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(100, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(199, 31);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yearly Expenses:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(100, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monthly Expenses:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblMonthlyIncome);
            this.panel2.Controls.Add(this.lblMonthlyExpenses);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblYearlyExpenses);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblYearlyIncome);
            this.panel2.Location = new System.Drawing.Point(845, 123);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(615, 268);
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
            this.wvReportView.Size = new System.Drawing.Size(1420, 880);
            this.wvReportView.Source = new System.Uri("http://www.google.com", System.UriKind.Absolute);
            this.wvReportView.TabIndex = 19;
            this.wvReportView.ZoomFactor = 1D;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.wvReportView);
            this.panel3.Location = new System.Drawing.Point(39, 500);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1422, 882);
            this.panel3.TabIndex = 20;
            // 
            // gbxReportType
            // 
            this.gbxReportType.Controls.Add(this.rbnInvestment);
            this.gbxReportType.Controls.Add(this.rbnExpense);
            this.gbxReportType.Controls.Add(this.rbnIncome);
            this.gbxReportType.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbxReportType.Location = new System.Drawing.Point(39, 107);
            this.gbxReportType.Name = "gbxReportType";
            this.gbxReportType.Size = new System.Drawing.Size(283, 233);
            this.gbxReportType.TabIndex = 21;
            this.gbxReportType.TabStop = false;
            // 
            // rbnInvestment
            // 
            this.rbnInvestment.AutoSize = true;
            this.rbnInvestment.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnInvestment.Location = new System.Drawing.Point(55, 167);
            this.rbnInvestment.Name = "rbnInvestment";
            this.rbnInvestment.Size = new System.Drawing.Size(181, 38);
            this.rbnInvestment.TabIndex = 2;
            this.rbnInvestment.TabStop = true;
            this.rbnInvestment.Text = "Investment";
            this.rbnInvestment.UseVisualStyleBackColor = true;
            // 
            // rbnExpense
            // 
            this.rbnExpense.AutoSize = true;
            this.rbnExpense.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnExpense.Location = new System.Drawing.Point(55, 116);
            this.rbnExpense.Name = "rbnExpense";
            this.rbnExpense.Size = new System.Drawing.Size(151, 38);
            this.rbnExpense.TabIndex = 1;
            this.rbnExpense.TabStop = true;
            this.rbnExpense.Text = "Expense";
            this.rbnExpense.UseVisualStyleBackColor = true;
            // 
            // rbnIncome
            // 
            this.rbnIncome.AutoSize = true;
            this.rbnIncome.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rbnIncome.Location = new System.Drawing.Point(55, 65);
            this.rbnIncome.Name = "rbnIncome";
            this.rbnIncome.Size = new System.Drawing.Size(140, 38);
            this.rbnIncome.TabIndex = 0;
            this.rbnIncome.TabStop = true;
            this.rbnIncome.Text = "Income";
            this.rbnIncome.UseVisualStyleBackColor = true;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(155, 20);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(247, 42);
            this.dtpStart.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(45, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 34);
            this.label4.TabIndex = 23;
            this.label4.Text = "Start:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(53, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 34);
            this.label5.TabIndex = 25;
            this.label5.Text = "End:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "MM/dd/yyyy";
            this.dtpEnd.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpEnd.Location = new System.Drawing.Point(155, 97);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(247, 42);
            this.dtpEnd.TabIndex = 24;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGenerateReport.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerateReport.Location = new System.Drawing.Point(534, 333);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(281, 58);
            this.btnGenerateReport.TabIndex = 26;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(362, 333);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 58);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(41, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 48);
            this.label8.TabIndex = 35;
            this.label8.Text = "Report Type";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label9.Location = new System.Drawing.Point(845, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(615, 48);
            this.label9.TabIndex = 36;
            this.label9.Text = "Quick View";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(362, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(449, 48);
            this.label10.TabIndex = 37;
            this.label10.Text = "Date Range";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtpEnd);
            this.panel1.Controls.Add(this.dtpStart);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(362, 124);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(449, 194);
            this.panel1.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Location = new System.Drawing.Point(39, 452);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1422, 48);
            this.label11.TabIndex = 39;
            this.label11.Text = "Report View";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ucReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.gbxReportType);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "ucReportForm";
            this.Size = new System.Drawing.Size(1486, 1446);
            this.Load += new System.EventHandler(this.ucReportForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvReportView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.gbxReportType.ResumeLayout(false);
            this.gbxReportType.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private Button btnClear;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
        private Label label11;
    }
}
