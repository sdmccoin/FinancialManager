namespace FinancialManager.UI.Controls
{
    partial class ucActiveNotificationsAndAlerts
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rbnEnable = new System.Windows.Forms.RadioButton();
            this.rbnDisable = new System.Windows.Forms.RadioButton();
            this.gbxStatus = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbxStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(935, 56);
            this.label8.TabIndex = 33;
            this.label8.Text = "Active Alerts & Notifications";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 49;
            this.dataGridView1.Size = new System.Drawing.Size(883, 470);
            this.dataGridView1.TabIndex = 34;
            // 
            // rbnEnable
            // 
            this.rbnEnable.AutoSize = true;
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
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(23, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 56);
            this.label1.TabIndex = 38;
            this.label1.Text = "Status";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.gbxStatus);
            this.panel1.Location = new System.Drawing.Point(23, 638);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 120);
            this.panel1.TabIndex = 39;
            // 
            // ucActiveNotificationsAndAlerts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label8);
            this.Name = "ucActiveNotificationsAndAlerts";
            this.Size = new System.Drawing.Size(928, 915);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbxStatus.ResumeLayout(false);
            this.gbxStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label label8;
        private DataGridView dataGridView1;
        private RadioButton rbnEnable;
        private RadioButton rbnDisable;
        private GroupBox gbxStatus;
        private Label label1;
        private Panel panel1;
    }
}
