namespace FinancialManager.UI.Controls
{
    partial class ucInvestmentForm
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
            this.dgvInvestments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gbxFrequency = new System.Windows.Forms.GroupBox();
            this.rbtnDaily = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbxType = new System.Windows.Forms.GroupBox();
            this.rbnOther = new System.Windows.Forms.RadioButton();
            this.rbnBond = new System.Windows.Forms.RadioButton();
            this.rbnStock = new System.Windows.Forms.RadioButton();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestments)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbxFrequency.SuspendLayout();
            this.gbxType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvestments
            // 
            this.dgvInvestments.AllowUserToAddRows = false;
            this.dgvInvestments.AllowUserToDeleteRows = false;
            this.dgvInvestments.AllowUserToResizeColumns = false;
            this.dgvInvestments.AllowUserToResizeRows = false;
            this.dgvInvestments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestments.Location = new System.Drawing.Point(53, 963);
            this.dgvInvestments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvInvestments.MultiSelect = false;
            this.dgvInvestments.Name = "dgvInvestments";
            this.dgvInvestments.ReadOnly = true;
            this.dgvInvestments.RowHeadersVisible = false;
            this.dgvInvestments.RowHeadersWidth = 102;
            this.dgvInvestments.RowTemplate.Height = 49;
            this.dgvInvestments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvestments.Size = new System.Drawing.Size(1370, 344);
            this.dgvInvestments.TabIndex = 11;
            this.dgvInvestments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvestments_CellDoubleClick);
            this.dgvInvestments.SelectionChanged += new System.EventHandler(this.dgvInvestments_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1484, 93);
            this.label1.TabIndex = 11;
            this.label1.Text = "Investments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvInvestments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1484, 1375);
            this.panel1.TabIndex = 12;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(496, 884);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 58);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(352, 884);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 58);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(200, 884);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 58);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(55, 884);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 58);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.gbxFrequency);
            this.groupBox1.Controls.Add(this.gbxType);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Location = new System.Drawing.Point(53, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.groupBox1.Size = new System.Drawing.Size(1040, 754);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Source of Investment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 41);
            this.label2.TabIndex = 16;
            this.label2.Text = "Notes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(50, 553);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(955, 181);
            this.textBox1.TabIndex = 15;
            // 
            // gbxFrequency
            // 
            this.gbxFrequency.Controls.Add(this.rbtnDaily);
            this.gbxFrequency.Controls.Add(this.radioButton2);
            this.gbxFrequency.Controls.Add(this.radioButton3);
            this.gbxFrequency.Controls.Add(this.radioButton5);
            this.gbxFrequency.Controls.Add(this.radioButton4);
            this.gbxFrequency.Location = new System.Drawing.Point(50, 261);
            this.gbxFrequency.Name = "gbxFrequency";
            this.gbxFrequency.Size = new System.Drawing.Size(778, 183);
            this.gbxFrequency.TabIndex = 14;
            this.gbxFrequency.TabStop = false;
            this.gbxFrequency.Text = "Frequency";
            // 
            // rbtnDaily
            // 
            this.rbtnDaily.AutoSize = true;
            this.rbtnDaily.Location = new System.Drawing.Point(59, 76);
            this.rbtnDaily.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.rbtnDaily.Name = "rbtnDaily";
            this.rbtnDaily.Size = new System.Drawing.Size(120, 45);
            this.rbtnDaily.TabIndex = 4;
            this.rbtnDaily.TabStop = true;
            this.rbtnDaily.Text = "Daily";
            this.rbtnDaily.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(193, 76);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(151, 45);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Weekly";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(358, 76);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(187, 45);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Bi-Weekly";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(59, 137);
            this.radioButton5.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(132, 45);
            this.radioButton5.TabIndex = 8;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Yearly";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(577, 76);
            this.radioButton4.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(166, 45);
            this.radioButton4.TabIndex = 7;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Monthly";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // gbxType
            // 
            this.gbxType.Controls.Add(this.rbnOther);
            this.gbxType.Controls.Add(this.rbnBond);
            this.gbxType.Controls.Add(this.rbnStock);
            this.gbxType.Location = new System.Drawing.Point(630, 39);
            this.gbxType.Name = "gbxType";
            this.gbxType.Size = new System.Drawing.Size(198, 227);
            this.gbxType.TabIndex = 12;
            this.gbxType.TabStop = false;
            this.gbxType.Text = "Type";
            // 
            // rbnOther
            // 
            this.rbnOther.AutoSize = true;
            this.rbnOther.Location = new System.Drawing.Point(36, 159);
            this.rbnOther.Name = "rbnOther";
            this.rbnOther.Size = new System.Drawing.Size(131, 45);
            this.rbnOther.TabIndex = 2;
            this.rbnOther.TabStop = true;
            this.rbnOther.Text = "Other";
            this.rbnOther.UseVisualStyleBackColor = true;
            // 
            // rbnBond
            // 
            this.rbnBond.AutoSize = true;
            this.rbnBond.Location = new System.Drawing.Point(36, 112);
            this.rbnBond.Name = "rbnBond";
            this.rbnBond.Size = new System.Drawing.Size(125, 45);
            this.rbnBond.TabIndex = 1;
            this.rbnBond.TabStop = true;
            this.rbnBond.Text = "Bond";
            this.rbnBond.UseVisualStyleBackColor = true;
            // 
            // rbnStock
            // 
            this.rbnStock.AutoSize = true;
            this.rbnStock.Location = new System.Drawing.Point(36, 64);
            this.rbnStock.Name = "rbnStock";
            this.rbnStock.Size = new System.Drawing.Size(127, 45);
            this.rbnStock.TabIndex = 0;
            this.rbnStock.TabStop = true;
            this.rbnStock.Text = "Stock";
            this.rbnStock.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(211, 154);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 47);
            this.txtAmount.TabIndex = 11;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(211, 85);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(366, 47);
            this.txtName.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 157);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 41);
            this.label11.TabIndex = 2;
            this.label11.Text = "Amount";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(50, 98);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 41);
            this.label13.TabIndex = 0;
            this.label13.Text = "Name";
            // 
            // ucInvestmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ucInvestmentForm";
            this.Size = new System.Drawing.Size(1484, 1375);
            this.Load += new System.EventHandler(this.ucInvestmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxFrequency.ResumeLayout(false);
            this.gbxFrequency.PerformLayout();
            this.gbxType.ResumeLayout(false);
            this.gbxType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvInvestments;
        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private Label label2;
        private TextBox textBox1;
        private GroupBox gbxFrequency;
        private RadioButton rbtnDaily;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private GroupBox gbxType;
        private RadioButton rbnOther;
        private RadioButton rbnBond;
        private RadioButton rbnStock;
        private TextBox txtAmount;
        private TextBox txtName;
        private Label label11;
        private Label label13;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
    }
}
