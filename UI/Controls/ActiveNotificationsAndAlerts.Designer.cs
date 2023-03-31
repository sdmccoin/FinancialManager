namespace FinancialManager.UI.Controls
{
    partial class ActiveNotificationsAndAlerts
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
            this.rbnEnable = new System.Windows.Forms.RadioButton();
            this.rbnDisable = new System.Windows.Forms.RadioButton();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvAlertsAndNotifications = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.gbxStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertsAndNotifications)).BeginInit();
            this.SuspendLayout();
            // 
            // rbnEnable
            // 
            this.rbnEnable.AutoSize = true;
            this.rbnEnable.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.rbnEnable.Location = new System.Drawing.Point(6, 0);
            this.rbnEnable.Name = "rbnEnable";
            this.rbnEnable.Size = new System.Drawing.Size(143, 45);
            this.rbnEnable.TabIndex = 35;
            this.rbnEnable.TabStop = true;
            this.rbnEnable.Text = "Enable";
            this.rbnEnable.UseVisualStyleBackColor = true;
            // 
            // rbnDisable
            // 
            this.rbnDisable.AutoSize = true;
            this.rbnDisable.ForeColor = System.Drawing.Color.LightCoral;
            this.rbnDisable.Location = new System.Drawing.Point(175, 0);
            this.rbnDisable.Name = "rbnDisable";
            this.rbnDisable.Size = new System.Drawing.Size(152, 45);
            this.rbnDisable.TabIndex = 36;
            this.rbnDisable.TabStop = true;
            this.rbnDisable.Text = "Disable";
            this.rbnDisable.UseVisualStyleBackColor = true;
            // 
            // gbxStatus
            // 
            this.gbxStatus.Controls.Add(this.rbnEnable);
            this.gbxStatus.Controls.Add(this.rbnDisable);
            this.gbxStatus.Location = new System.Drawing.Point(22, 28);
            this.gbxStatus.Name = "gbxStatus";
            this.gbxStatus.Size = new System.Drawing.Size(357, 66);
            this.gbxStatus.TabIndex = 37;
            this.gbxStatus.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbxStatus);
            this.panel1.Location = new System.Drawing.Point(64, 622);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 120);
            this.panel1.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(64, 565);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 56);
            this.label1.TabIndex = 42;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvAlertsAndNotifications);
            this.panel2.Location = new System.Drawing.Point(28, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(964, 447);
            this.panel2.TabIndex = 44;
            // 
            // dgvAlertsAndNotifications
            // 
            this.dgvAlertsAndNotifications.AllowUserToAddRows = false;
            this.dgvAlertsAndNotifications.AllowUserToDeleteRows = false;
            this.dgvAlertsAndNotifications.AllowUserToResizeColumns = false;
            this.dgvAlertsAndNotifications.AllowUserToResizeRows = false;
            this.dgvAlertsAndNotifications.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvAlertsAndNotifications.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlertsAndNotifications.ColumnHeadersVisible = false;
            this.dgvAlertsAndNotifications.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAlertsAndNotifications.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAlertsAndNotifications.Location = new System.Drawing.Point(0, 0);
            this.dgvAlertsAndNotifications.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvAlertsAndNotifications.MultiSelect = false;
            this.dgvAlertsAndNotifications.Name = "dgvAlertsAndNotifications";
            this.dgvAlertsAndNotifications.ReadOnly = true;
            this.dgvAlertsAndNotifications.RowHeadersVisible = false;
            this.dgvAlertsAndNotifications.RowHeadersWidth = 102;
            this.dgvAlertsAndNotifications.RowTemplate.Height = 49;
            this.dgvAlertsAndNotifications.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlertsAndNotifications.ShowCellErrors = false;
            this.dgvAlertsAndNotifications.ShowCellToolTips = false;
            this.dgvAlertsAndNotifications.ShowEditingIcon = false;
            this.dgvAlertsAndNotifications.ShowRowErrors = false;
            this.dgvAlertsAndNotifications.Size = new System.Drawing.Size(964, 447);
            this.dgvAlertsAndNotifications.TabIndex = 13;
            this.dgvAlertsAndNotifications.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvAlertsAndNotifications_RowPrePaint);
            this.dgvAlertsAndNotifications.SelectionChanged += new System.EventHandler(this.dgvAlertsAndNotifications_SelectionChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(28, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(964, 56);
            this.label2.TabIndex = 45;
            this.label2.Text = "Alerts / Notifications";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSave.Location = new System.Drawing.Point(535, 622);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 58);
            this.btnSave.TabIndex = 46;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // ActiveNotificationsAndAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1017, 774);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActiveNotificationsAndAlerts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Active Alerts & Notifications";
            this.Load += new System.EventHandler(this.ActiveNotificationsAndAlerts_Load);
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlertsAndNotifications)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RadioButton rbnEnable;
        private RadioButton rbnDisable;
        private GroupBox gbxStatus;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label label2;
        private DataGridView dgvAlertsAndNotifications;
        private Button btnSave;
    }
}