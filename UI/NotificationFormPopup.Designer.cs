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
            this.cbxReminder = new System.Windows.Forms.CheckBox();
            this.cbxNotification = new System.Windows.Forms.CheckBox();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.rbtnDaily = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.cbxRecurrence = new System.Windows.Forms.CheckBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
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
            // cbxReminder
            // 
            this.cbxReminder.AutoSize = true;
            this.cbxReminder.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxReminder.Location = new System.Drawing.Point(101, 320);
            this.cbxReminder.Name = "cbxReminder";
            this.cbxReminder.Size = new System.Drawing.Size(245, 45);
            this.cbxReminder.TabIndex = 8;
            this.cbxReminder.Text = "Set Reminder";
            this.cbxReminder.UseVisualStyleBackColor = true;
            this.cbxReminder.Visible = false;
            this.cbxReminder.CheckedChanged += new System.EventHandler(this.cbxReminder_CheckedChanged);
            // 
            // cbxNotification
            // 
            this.cbxNotification.AutoSize = true;
            this.cbxNotification.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxNotification.Location = new System.Drawing.Point(381, 320);
            this.cbxNotification.Name = "cbxNotification";
            this.cbxNotification.Size = new System.Drawing.Size(280, 45);
            this.cbxNotification.TabIndex = 9;
            this.cbxNotification.Text = "Set Notification";
            this.cbxNotification.UseVisualStyleBackColor = true;
            this.cbxNotification.Visible = false;
            this.cbxNotification.CheckedChanged += new System.EventHandler(this.cbxNotification_CheckedChanged);
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.btnClear);
            this.pnlMain.Controls.Add(this.btnDelete);
            this.pnlMain.Controls.Add(this.btnUpdate);
            this.pnlMain.Controls.Add(this.btnInsert);
            this.pnlMain.Controls.Add(this.label11);
            this.pnlMain.Controls.Add(this.dtpTime);
            this.pnlMain.Controls.Add(this.groupBox1);
            this.pnlMain.Controls.Add(this.cbxRecurrence);
            this.pnlMain.Controls.Add(this.monthCalendar1);
            this.pnlMain.Controls.Add(this.label10);
            this.pnlMain.Controls.Add(this.label9);
            this.pnlMain.Controls.Add(this.txtMessage);
            this.pnlMain.Location = new System.Drawing.Point(101, 384);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(933, 807);
            this.pnlMain.TabIndex = 10;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(718, 712);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 58);
            this.btnClear.TabIndex = 43;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(574, 712);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 58);
            this.btnDelete.TabIndex = 42;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(422, 712);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 58);
            this.btnUpdate.TabIndex = 41;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(277, 712);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 58);
            this.btnInsert.TabIndex = 40;
            this.btnInsert.Text = "Add";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(496, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 41);
            this.label11.TabIndex = 39;
            this.label11.Text = "Time:";
            // 
            // dtpTime
            // 
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTime.Location = new System.Drawing.Point(610, 37);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(259, 47);
            this.dtpTime.TabIndex = 38;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton5);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton4);
            this.groupBox1.Controls.Add(this.rbtnDaily);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Location = new System.Drawing.Point(610, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 348);
            this.groupBox1.TabIndex = 37;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Frequency";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(35, 261);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(132, 45);
            this.radioButton5.TabIndex = 21;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Yearly";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(35, 112);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 45);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Weekly";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(35, 213);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(166, 45);
            this.radioButton4.TabIndex = 20;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Monthly";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // rbtnDaily
            // 
            this.rbtnDaily.AutoSize = true;
            this.rbtnDaily.Location = new System.Drawing.Point(35, 58);
            this.rbtnDaily.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rbtnDaily.Name = "rbtnDaily";
            this.rbtnDaily.Size = new System.Drawing.Size(120, 45);
            this.rbtnDaily.TabIndex = 17;
            this.rbtnDaily.TabStop = true;
            this.rbtnDaily.Text = "Daily";
            this.rbtnDaily.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(35, 163);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(187, 45);
            this.radioButton3.TabIndex = 19;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bi-Weekly";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // cbxRecurrence
            // 
            this.cbxRecurrence.AutoSize = true;
            this.cbxRecurrence.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cbxRecurrence.Location = new System.Drawing.Point(608, 144);
            this.cbxRecurrence.Name = "cbxRecurrence";
            this.cbxRecurrence.Size = new System.Drawing.Size(211, 45);
            this.cbxRecurrence.TabIndex = 36;
            this.cbxRecurrence.Text = "Recurrence";
            this.cbxRecurrence.UseVisualStyleBackColor = true;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(63, 102);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(63, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 41);
            this.label10.TabIndex = 34;
            this.label10.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(67, 544);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 41);
            this.label9.TabIndex = 33;
            this.label9.Text = "Message";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(67, 588);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(800, 118);
            this.txtMessage.TabIndex = 32;
            // 
            // NotificationFormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 1227);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.cbxNotification);
            this.Controls.Add(this.cbxReminder);
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
            this.Text = "Set Reminder/Notification";
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
        private CheckBox cbxReminder;
        private CheckBox cbxNotification;
        private Panel pnlMain;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Label label11;
        private DateTimePicker dtpTime;
        private GroupBox groupBox1;
        private RadioButton radioButton5;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private RadioButton rbtnDaily;
        private RadioButton radioButton3;
        private CheckBox cbxRecurrence;
        private MonthCalendar monthCalendar1;
        private Label label10;
        private Label label9;
        private TextBox txtMessage;
    }
}