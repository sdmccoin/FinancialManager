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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1484, 93);
            this.label1.TabIndex = 12;
            this.label1.Text = "Reporting";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Monthly Income:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 41);
            this.label3.TabIndex = 1;
            this.label3.Text = "Annual Income:";
            // 
            // lblMonthlyIncome
            // 
            this.lblMonthlyIncome.AutoSize = true;
            this.lblMonthlyIncome.Location = new System.Drawing.Point(619, 117);
            this.lblMonthlyIncome.Name = "lblMonthlyIncome";
            this.lblMonthlyIncome.Size = new System.Drawing.Size(50, 41);
            this.lblMonthlyIncome.TabIndex = 13;
            this.lblMonthlyIncome.Text = "$0";
            // 
            // lblYearlyIncome
            // 
            this.lblYearlyIncome.AutoSize = true;
            this.lblYearlyIncome.Location = new System.Drawing.Point(619, 170);
            this.lblYearlyIncome.Name = "lblYearlyIncome";
            this.lblYearlyIncome.Size = new System.Drawing.Size(50, 41);
            this.lblYearlyIncome.TabIndex = 14;
            this.lblYearlyIncome.Text = "$0";
            // 
            // lblYearlyExpenses
            // 
            this.lblYearlyExpenses.AutoSize = true;
            this.lblYearlyExpenses.Location = new System.Drawing.Point(1088, 170);
            this.lblYearlyExpenses.Name = "lblYearlyExpenses";
            this.lblYearlyExpenses.Size = new System.Drawing.Size(50, 41);
            this.lblYearlyExpenses.TabIndex = 14;
            this.lblYearlyExpenses.Text = "$0";
            // 
            // lblMonthlyExpenses
            // 
            this.lblMonthlyExpenses.AutoSize = true;
            this.lblMonthlyExpenses.Location = new System.Drawing.Point(1088, 117);
            this.lblMonthlyExpenses.Name = "lblMonthlyExpenses";
            this.lblMonthlyExpenses.Size = new System.Drawing.Size(50, 41);
            this.lblMonthlyExpenses.TabIndex = 13;
            this.lblMonthlyExpenses.Text = "$0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(796, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 41);
            this.label6.TabIndex = 1;
            this.label6.Text = "Yearly Expenses:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(796, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(266, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Monthly Expenses:";
            // 
            // ucReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblYearlyExpenses);
            this.Controls.Add(this.lblYearlyIncome);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMonthlyExpenses);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblMonthlyIncome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "ucReportForm";
            this.Size = new System.Drawing.Size(1484, 1375);
            this.Load += new System.EventHandler(this.ucReportForm_Load);
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
    }
}
