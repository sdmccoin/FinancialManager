namespace FinancialManager.UI
{
    partial class AddInvestmentPopup
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbxFrequency = new System.Windows.Forms.GroupBox();
            this.rbnMonthly = new System.Windows.Forms.RadioButton();
            this.rbnWeekly = new System.Windows.Forms.RadioButton();
            this.rbnDaily = new System.Windows.Forms.RadioButton();
            this.cbxMonitor = new System.Windows.Forms.CheckBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.gbxFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(356, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Investment Amount:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(392, 36);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(250, 47);
            this.txtAmount.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(309, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 46);
            this.label2.TabIndex = 2;
            this.label2.Text = "OR";
            // 
            // gbxFrequency
            // 
            this.gbxFrequency.Controls.Add(this.rbnMonthly);
            this.gbxFrequency.Controls.Add(this.rbnWeekly);
            this.gbxFrequency.Controls.Add(this.rbnDaily);
            this.gbxFrequency.Location = new System.Drawing.Point(36, 277);
            this.gbxFrequency.Name = "gbxFrequency";
            this.gbxFrequency.Size = new System.Drawing.Size(637, 147);
            this.gbxFrequency.TabIndex = 4;
            this.gbxFrequency.TabStop = false;
            this.gbxFrequency.Text = "How often would you like to receive updates?";
            // 
            // rbnMonthly
            // 
            this.rbnMonthly.AutoSize = true;
            this.rbnMonthly.Location = new System.Drawing.Point(330, 67);
            this.rbnMonthly.Name = "rbnMonthly";
            this.rbnMonthly.Size = new System.Drawing.Size(166, 45);
            this.rbnMonthly.TabIndex = 2;
            this.rbnMonthly.TabStop = true;
            this.rbnMonthly.Text = "Monthly";
            this.rbnMonthly.UseVisualStyleBackColor = true;
            // 
            // rbnWeekly
            // 
            this.rbnWeekly.AutoSize = true;
            this.rbnWeekly.Location = new System.Drawing.Point(173, 67);
            this.rbnWeekly.Name = "rbnWeekly";
            this.rbnWeekly.Size = new System.Drawing.Size(151, 45);
            this.rbnWeekly.TabIndex = 1;
            this.rbnWeekly.TabStop = true;
            this.rbnWeekly.Text = "Weekly";
            this.rbnWeekly.UseVisualStyleBackColor = true;
            // 
            // rbnDaily
            // 
            this.rbnDaily.AutoSize = true;
            this.rbnDaily.Location = new System.Drawing.Point(47, 67);
            this.rbnDaily.Name = "rbnDaily";
            this.rbnDaily.Size = new System.Drawing.Size(120, 45);
            this.rbnDaily.TabIndex = 0;
            this.rbnDaily.TabStop = true;
            this.rbnDaily.Text = "Daily";
            this.rbnDaily.UseVisualStyleBackColor = true;
            // 
            // cbxMonitor
            // 
            this.cbxMonitor.AutoSize = true;
            this.cbxMonitor.Location = new System.Drawing.Point(36, 189);
            this.cbxMonitor.Name = "cbxMonitor";
            this.cbxMonitor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbxMonitor.Size = new System.Drawing.Size(318, 45);
            this.cbxMonitor.TabIndex = 5;
            this.cbxMonitor.Text = "Monitor Investment";
            this.cbxMonitor.UseVisualStyleBackColor = true;
            this.cbxMonitor.CheckedChanged += new System.EventHandler(this.cbxMonitor_CheckedChanged);
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDone.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDone.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDone.Location = new System.Drawing.Point(283, 455);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(116, 47);
            this.btnDone.TabIndex = 6;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // AddInvestmentPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(705, 542);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.cbxMonitor);
            this.Controls.Add(this.gbxFrequency);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddInvestmentPopup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Investment";
            this.Load += new System.EventHandler(this.AddInvestmentPopup_Load);
            this.gbxFrequency.ResumeLayout(false);
            this.gbxFrequency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAmount;
        private Label label2;
        private GroupBox gbxFrequency;
        private RadioButton rbnMonthly;
        private RadioButton rbnWeekly;
        private RadioButton rbnDaily;
        private CheckBox cbxMonitor;
        private Button btnDone;
    }
}