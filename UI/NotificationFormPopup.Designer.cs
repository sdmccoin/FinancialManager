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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxReminder = new System.Windows.Forms.CheckBox();
            this.cbxNotification = new System.Windows.Forms.CheckBox();
            this.pnlMain = new System.Windows.Forms.Panel();
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(172, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 41);
            this.label5.TabIndex = 4;
            this.label5.Text = "...";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 41);
            this.label6.TabIndex = 5;
            this.label6.Text = "...";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 41);
            this.label7.TabIndex = 6;
            this.label7.Text = "...";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(188, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 41);
            this.label8.TabIndex = 7;
            this.label8.Text = "...";
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
            this.pnlMain.Location = new System.Drawing.Point(101, 384);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(933, 807);
            this.pnlMain.TabIndex = 10;
            // 
            // NotificationFormPopup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 1227);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.cbxNotification);
            this.Controls.Add(this.cbxReminder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NotificationFormPopup";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Reminder/Notification";
            this.Load += new System.EventHandler(this.NotificationFormPopup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private CheckBox cbxReminder;
        private CheckBox cbxNotification;
        private Panel pnlMain;
    }
}