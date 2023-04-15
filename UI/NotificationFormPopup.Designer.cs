namespace FinancialManager.UI
{
    partial class NotificationFormPopup
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblFrequency = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnDaily = new System.Windows.Forms.RadioButton();
            this.rbnWeekly = new System.Windows.Forms.RadioButton();
            this.rbnMonthly = new System.Windows.Forms.RadioButton();
            this.rbnYearly = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 41);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Frequency:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 41);
            this.label4.TabIndex = 3;
            this.label4.Text = "Amount:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(172, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 41);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "...";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(188, 87);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(39, 41);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "...";
            // 
            // lblFrequency
            // 
            this.lblFrequency.AutoSize = true;
            this.lblFrequency.Location = new System.Drawing.Point(231, 177);
            this.lblFrequency.Name = "lblFrequency";
            this.lblFrequency.Size = new System.Drawing.Size(39, 41);
            this.lblFrequency.TabIndex = 6;
            this.lblFrequency.Text = "...";
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(188, 240);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(39, 41);
            this.lblAmount.TabIndex = 7;
            this.lblAmount.Text = "...";
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.label6);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnUpdate);
            this.pnlMain.Controls.Add(this.btnInsert);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.dtpTime);
            this.pnlMain.Controls.Add(this.monthCalendar1);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtMessage);
            this.pnlMain.Location = new System.Drawing.Point(101, 384);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(858, 807);
            this.pnlMain.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnClear.Location = new System.Drawing.Point(461, 712);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 58);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(318, 712);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 58);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUpdate.Location = new System.Drawing.Point(172, 712);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 58);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInsert.Location = new System.Drawing.Point(39, 712);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 58);
            this.btnInsert.TabIndex = 40;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 35);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 41);
            this.label11.TabIndex = 39;
            this.label11.Text = "Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(213, 30);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(259, 47);
            this.dtpTime.TabIndex = 38;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(59, 102);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 41);
            this.label9.TabIndex = 33;
            this.label9.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMessage.Location = new System.Drawing.Point(39, 588);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(743, 118);
            this.txtMessage.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(101, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(855, 56);
            this.label5.TabIndex = 26;
            this.label5.Text = "Reminder Details";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnYearly);
            this.groupBox1.Controls.Add(this.rbnMonthly);
            this.groupBox1.Controls.Add(this.rbnWeekly);
            this.groupBox1.Controls.Add(this.rbnDaily);
            this.groupBox1.Location = new System.Drawing.Point(590, 80);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 421);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            // 
            // rbnDaily
            // 
            this.rbnDaily.AutoSize = true;
            this.rbnDaily.Location = new System.Drawing.Point(34, 46);
            this.rbnDaily.Name = "rbnDaily";
            this.rbnDaily.Size = new System.Drawing.Size(120, 45);
            this.rbnDaily.TabIndex = 0;
            this.rbnDaily.TabStop = true;
            this.rbnDaily.Text = "Daily";
            this.rbnDaily.UseVisualStyleBackColor = true;
            // 
            // rbnWeekly
            // 
            this.rbnWeekly.AutoSize = true;
            this.rbnWeekly.Location = new System.Drawing.Point(34, 97);
            this.rbnWeekly.Name = "rbnWeekly";
            this.rbnWeekly.Size = new System.Drawing.Size(151, 45);
            this.rbnWeekly.TabIndex = 1;
            this.rbnWeekly.TabStop = true;
            this.rbnWeekly.Text = "Weekly";
            this.rbnWeekly.UseVisualStyleBackColor = true;
            // 
            // rbnMonthly
            // 
            this.rbnMonthly.AutoSize = true;
            this.rbnMonthly.Location = new System.Drawing.Point(34, 148);
            this.rbnMonthly.Name = "rbnMonthly";
            this.rbnMonthly.Size = new System.Drawing.Size(166, 45);
            this.rbnMonthly.TabIndex = 2;
            this.rbnMonthly.TabStop = true;
            this.rbnMonthly.Text = "Monthly";
            this.rbnMonthly.UseVisualStyleBackColor = true;
            // 
            // rbnYearly
            // 
            this.rbnYearly.AutoSize = true;
            this.rbnYearly.Location = new System.Drawing.Point(34, 199);
            this.rbnYearly.Name = "rbnYearly";
            this.rbnYearly.Size = new System.Drawing.Size(132, 45);
            this.rbnYearly.TabIndex = 3;
            this.rbnYearly.TabStop = true;
            this.rbnYearly.Text = "Yearly";
            this.rbnYearly.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(590, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(163, 41);
            this.label6.TabIndex = 44;
            this.label6.Text = "Frequency:";
            // 
            // NotificationFormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(997, 1227);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.lblFrequency);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NotificationFormPopup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Reminder";
            this.Load += new System.EventHandler(this.NotificationFormPopup_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblName;
        private Label lblAddress;
        private Label lblFrequency;
        private Label lblAmount;
        private Panel pnlMain;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label11;
        private DateTimePicker dtpTime;
        private MonthCalendar monthCalendar1;
        private Label label9;
        private TextBox txtMessage;
        private Label label5;
        private Label label6;
        private GroupBox groupBox1;
        private RadioButton rbnYearly;
        private RadioButton rbnMonthly;
        private RadioButton rbnWeekly;
        private RadioButton rbnDaily;
    }
}