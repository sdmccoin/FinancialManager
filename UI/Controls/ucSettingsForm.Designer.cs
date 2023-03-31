namespace FinancialManager.UI.Controls
{
    partial class ucSettingsForm
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
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmailAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConfidenceLevel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTimeInterval = new System.Windows.Forms.TextBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblAlertDays = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.lblEnabled = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.lblConfidenceLevel = new System.Windows.Forms.Label();
            this.lblPredictionTimeInterval = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.gbxNotificationAlertStatus = new System.Windows.Forms.GroupBox();
            this.rbnEnabled = new System.Windows.Forms.RadioButton();
            this.rbnDisabled = new System.Windows.Forms.RadioButton();
            this.label18 = new System.Windows.Forms.Label();
            this.txtAlertDays = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.gbxNotificationAlertStatus.SuspendLayout();
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
            this.label1.TabIndex = 12;
            this.label1.Text = "Settings";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhone.Location = new System.Drawing.Point(168, 95);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(225, 47);
            this.txtPhone.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone:";
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEmailAddress.Location = new System.Drawing.Point(168, 21);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.Size = new System.Drawing.Size(417, 47);
            this.txtEmailAddress.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 41);
            this.label2.TabIndex = 0;
            this.label2.Text = "Email:";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSave.Location = new System.Drawing.Point(787, 826);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 47);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtEmailAddress);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(63, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 217);
            this.panel1.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(63, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(624, 56);
            this.label5.TabIndex = 41;
            this.label5.Text = "General";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(63, 409);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(624, 56);
            this.label4.TabIndex = 43;
            this.label4.Text = "Investment Analysis";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txtConfidenceLevel);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtTimeInterval);
            this.panel2.Controls.Add(this.trackBar1);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(63, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 252);
            this.panel2.TabIndex = 42;
            // 
            // txtConfidenceLevel
            // 
            this.txtConfidenceLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConfidenceLevel.Location = new System.Drawing.Point(297, 150);
            this.txtConfidenceLevel.Name = "txtConfidenceLevel";
            this.txtConfidenceLevel.Size = new System.Drawing.Size(67, 47);
            this.txtConfidenceLevel.TabIndex = 46;
            this.txtConfidenceLevel.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(251, 41);
            this.label6.TabIndex = 45;
            this.label6.Text = "Confidence Level:";
            // 
            // txtTimeInterval
            // 
            this.txtTimeInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTimeInterval.Location = new System.Drawing.Point(383, 21);
            this.txtTimeInterval.Name = "txtTimeInterval";
            this.txtTimeInterval.Size = new System.Drawing.Size(67, 47);
            this.txtTimeInterval.TabIndex = 44;
            this.txtTimeInterval.Text = "1";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(40, 71);
            this.trackBar1.Maximum = 180;
            this.trackBar1.Minimum = 1;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(553, 114);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.Value = 1;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(337, 41);
            this.label7.TabIndex = 0;
            this.label7.Text = "Prediction Time Interval:";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(787, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(624, 56);
            this.label8.TabIndex = 45;
            this.label8.Text = "Current Settings";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.lblAlertDays);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.lblEnabled);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.lblConfidenceLevel);
            this.panel3.Controls.Add(this.lblPredictionTimeInterval);
            this.panel3.Controls.Add(this.lblPhone);
            this.panel3.Controls.Add(this.lblEmail);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Location = new System.Drawing.Point(787, 152);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(624, 645);
            this.panel3.TabIndex = 44;
            // 
            // lblAlertDays
            // 
            this.lblAlertDays.AutoSize = true;
            this.lblAlertDays.Location = new System.Drawing.Point(283, 540);
            this.lblAlertDays.Name = "lblAlertDays";
            this.lblAlertDays.Size = new System.Drawing.Size(30, 41);
            this.lblAlertDays.TabIndex = 59;
            this.lblAlertDays.Text = "-";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(349, 540);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(79, 41);
            this.label20.TabIndex = 58;
            this.label20.Text = "days";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(91, 540);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(174, 41);
            this.label21.TabIndex = 56;
            this.label21.Text = "Alert Within";
            // 
            // lblEnabled
            // 
            this.lblEnabled.AutoSize = true;
            this.lblEnabled.Location = new System.Drawing.Point(244, 484);
            this.lblEnabled.Name = "lblEnabled";
            this.lblEnabled.Size = new System.Drawing.Size(30, 41);
            this.lblEnabled.TabIndex = 55;
            this.lblEnabled.Text = "-";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(91, 484);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(124, 41);
            this.label19.TabIndex = 54;
            this.label19.Text = "Enabled";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(45, 406);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(367, 41);
            this.label16.TabIndex = 53;
            this.label16.Text = "Reminders & Notifications";
            // 
            // lblConfidenceLevel
            // 
            this.lblConfidenceLevel.AutoSize = true;
            this.lblConfidenceLevel.Location = new System.Drawing.Point(377, 325);
            this.lblConfidenceLevel.Name = "lblConfidenceLevel";
            this.lblConfidenceLevel.Size = new System.Drawing.Size(30, 41);
            this.lblConfidenceLevel.TabIndex = 52;
            this.lblConfidenceLevel.Text = "-";
            // 
            // lblPredictionTimeInterval
            // 
            this.lblPredictionTimeInterval.AutoSize = true;
            this.lblPredictionTimeInterval.Location = new System.Drawing.Point(457, 264);
            this.lblPredictionTimeInterval.Name = "lblPredictionTimeInterval";
            this.lblPredictionTimeInterval.Size = new System.Drawing.Size(30, 41);
            this.lblPredictionTimeInterval.TabIndex = 51;
            this.lblPredictionTimeInterval.Text = "-";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(209, 136);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(30, 41);
            this.lblPhone.TabIndex = 50;
            this.lblPhone.Text = "-";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(207, 84);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(30, 41);
            this.lblEmail.TabIndex = 49;
            this.lblEmail.Text = "-";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(91, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(251, 41);
            this.label12.TabIndex = 46;
            this.label12.Text = "Confidence Level:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(91, 271);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(337, 41);
            this.label11.TabIndex = 3;
            this.label11.Text = "Prediction Time Interval:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(45, 196);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(299, 41);
            this.label14.TabIndex = 48;
            this.label14.Text = "Investment Analysis";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(45, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 41);
            this.label13.TabIndex = 47;
            this.label13.Text = "General";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(91, 136);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 41);
            this.label9.TabIndex = 2;
            this.label9.Text = "Phone:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(91, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 41);
            this.label10.TabIndex = 0;
            this.label10.Text = "Email:";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(1033, 826);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(116, 47);
            this.btnClear.TabIndex = 46;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label15.Location = new System.Drawing.Point(63, 765);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(624, 56);
            this.label15.TabIndex = 48;
            this.label15.Text = "Reminders & Notifications";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.gbxNotificationAlertStatus);
            this.panel4.Controls.Add(this.label18);
            this.panel4.Controls.Add(this.txtAlertDays);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Location = new System.Drawing.Point(63, 822);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(624, 252);
            this.panel4.TabIndex = 47;
            // 
            // gbxNotificationAlertStatus
            // 
            this.gbxNotificationAlertStatus.Controls.Add(this.rbnEnabled);
            this.gbxNotificationAlertStatus.Controls.Add(this.rbnDisabled);
            this.gbxNotificationAlertStatus.Location = new System.Drawing.Point(40, 3);
            this.gbxNotificationAlertStatus.Name = "gbxNotificationAlertStatus";
            this.gbxNotificationAlertStatus.Size = new System.Drawing.Size(395, 120);
            this.gbxNotificationAlertStatus.TabIndex = 50;
            this.gbxNotificationAlertStatus.TabStop = false;
            // 
            // rbnEnabled
            // 
            this.rbnEnabled.AutoSize = true;
            this.rbnEnabled.Location = new System.Drawing.Point(27, 46);
            this.rbnEnabled.Name = "rbnEnabled";
            this.rbnEnabled.Size = new System.Drawing.Size(161, 45);
            this.rbnEnabled.TabIndex = 48;
            this.rbnEnabled.TabStop = true;
            this.rbnEnabled.Text = "Enabled";
            this.rbnEnabled.UseVisualStyleBackColor = true;
            // 
            // rbnDisabled
            // 
            this.rbnDisabled.AutoSize = true;
            this.rbnDisabled.Location = new System.Drawing.Point(194, 46);
            this.rbnDisabled.Name = "rbnDisabled";
            this.rbnDisabled.Size = new System.Drawing.Size(170, 45);
            this.rbnDisabled.TabIndex = 49;
            this.rbnDisabled.TabStop = true;
            this.rbnDisabled.Text = "Disabled";
            this.rbnDisabled.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(298, 153);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 41);
            this.label18.TabIndex = 47;
            this.label18.Text = "days";
            // 
            // txtAlertDays
            // 
            this.txtAlertDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAlertDays.Location = new System.Drawing.Point(220, 147);
            this.txtAlertDays.Name = "txtAlertDays";
            this.txtAlertDays.Size = new System.Drawing.Size(67, 47);
            this.txtAlertDays.TabIndex = 44;
            this.txtAlertDays.Text = "1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 153);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(174, 41);
            this.label17.TabIndex = 0;
            this.label17.Text = "Alert Within";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(911, 826);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 47);
            this.btnUpdate.TabIndex = 49;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ucSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Name = "ucSettingsForm";
            this.Size = new System.Drawing.Size(1486, 1494);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.gbxNotificationAlertStatus.ResumeLayout(false);
            this.gbxNotificationAlertStatus.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtEmailAddress;
        private Label label2;
        private Button btnSave;
        private Panel panel1;
        private Label label5;
        private Label label4;
        private Panel panel2;
        private TrackBar trackBar1;
        private Label label7;
        private TextBox txtTimeInterval;
        private TextBox txtConfidenceLevel;
        private Label label6;
        private Label label8;
        private Panel panel3;
        private Label lblConfidenceLevel;
        private Label lblPredictionTimeInterval;
        private Label lblPhone;
        private Label lblEmail;
        private Label label12;
        private Label label11;
        private Label label14;
        private Label label13;
        private Label label9;
        private Label label10;
        private Button btnClear;
        private Label label15;
        private Panel panel4;
        private Label label18;
        private TextBox txtAlertDays;
        private Label label17;
        private Label lblAlertDays;
        private Label label20;
        private Label label21;
        private Label lblEnabled;
        private Label label19;
        private Label label16;
        private GroupBox gbxNotificationAlertStatus;
        private RadioButton rbnEnabled;
        private RadioButton rbnDisabled;
        private Button btnUpdate;
    }
}
