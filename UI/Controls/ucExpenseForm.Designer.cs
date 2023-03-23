namespace FinancialManager.UI.Controls
{
    partial class ucExpenseForm
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvExpenses = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvExpenseEvents = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsert.Location = new System.Drawing.Point(52, 1327);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(132, 58);
            this.btnInsert.TabIndex = 12;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
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
            this.label1.TabIndex = 11;
            this.label1.Text = "Expenses";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 1446);
            this.panel1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvExpenses);
            this.panel4.Location = new System.Drawing.Point(54, 650);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1373, 629);
            this.panel4.TabIndex = 38;
            // 
            // dgvExpenses
            // 
            this.dgvExpenses.AllowUserToAddRows = false;
            this.dgvExpenses.AllowUserToDeleteRows = false;
            this.dgvExpenses.AllowUserToResizeColumns = false;
            this.dgvExpenses.AllowUserToResizeRows = false;
            this.dgvExpenses.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvExpenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenses.Location = new System.Drawing.Point(0, 0);
            this.dgvExpenses.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvExpenses.MultiSelect = false;
            this.dgvExpenses.Name = "dgvExpenses";
            this.dgvExpenses.ReadOnly = true;
            this.dgvExpenses.RowHeadersVisible = false;
            this.dgvExpenses.RowHeadersWidth = 102;
            this.dgvExpenses.RowTemplate.Height = 49;
            this.dgvExpenses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenses.Size = new System.Drawing.Size(1373, 629);
            this.dgvExpenses.TabIndex = 11;
            this.dgvExpenses.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpenses_CellDoubleClick);
            this.dgvExpenses.SelectionChanged += new System.EventHandler(this.dgvExpenses_SelectionChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(54, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1373, 48);
            this.label2.TabIndex = 37;
            this.label2.Text = "Current Expenses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.txtNotes);
            this.panel3.Controls.Add(this.dtpStart);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Location = new System.Drawing.Point(54, 140);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 411);
            this.panel3.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Location = new System.Drawing.Point(113, 44);
            this.txtName.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(548, 47);
            this.txtName.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 53);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 34);
            this.label5.TabIndex = 0;
            this.label5.Text = "Name";
            // 
            // txtNotes
            // 
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Location = new System.Drawing.Point(13, 230);
            this.txtNotes.Multiline = true;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(636, 125);
            this.txtNotes.TabIndex = 30;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "MM/dd/yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpStart.Location = new System.Drawing.Point(402, 119);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(247, 42);
            this.dtpStart.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(13, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 34);
            this.label10.TabIndex = 31;
            this.label10.Text = "Notes";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(13, 123);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(112, 34);
            this.label11.TabIndex = 27;
            this.label11.Text = "Amount";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(314, 125);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 34);
            this.label12.TabIndex = 29;
            this.label12.Text = "Date:";
            // 
            // txtAmount
            // 
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(134, 114);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(135, 47);
            this.txtAmount.TabIndex = 28;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(54, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(694, 48);
            this.label13.TabIndex = 36;
            this.label13.Text = "Source of Expense";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvExpenseEvents);
            this.panel2.Location = new System.Drawing.Point(780, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 411);
            this.panel2.TabIndex = 26;
            // 
            // dgvExpenseEvents
            // 
            this.dgvExpenseEvents.AllowUserToAddRows = false;
            this.dgvExpenseEvents.AllowUserToDeleteRows = false;
            this.dgvExpenseEvents.AllowUserToResizeColumns = false;
            this.dgvExpenseEvents.AllowUserToResizeRows = false;
            this.dgvExpenseEvents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvExpenseEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpenseEvents.ColumnHeadersVisible = false;
            this.dgvExpenseEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvExpenseEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvExpenseEvents.Location = new System.Drawing.Point(0, 0);
            this.dgvExpenseEvents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvExpenseEvents.MultiSelect = false;
            this.dgvExpenseEvents.Name = "dgvExpenseEvents";
            this.dgvExpenseEvents.ReadOnly = true;
            this.dgvExpenseEvents.RowHeadersVisible = false;
            this.dgvExpenseEvents.RowHeadersWidth = 102;
            this.dgvExpenseEvents.RowTemplate.Height = 49;
            this.dgvExpenseEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpenseEvents.ShowCellErrors = false;
            this.dgvExpenseEvents.ShowCellToolTips = false;
            this.dgvExpenseEvents.ShowEditingIcon = false;
            this.dgvExpenseEvents.ShowRowErrors = false;
            this.dgvExpenseEvents.Size = new System.Drawing.Size(639, 411);
            this.dgvExpenseEvents.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(780, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(639, 56);
            this.label8.TabIndex = 27;
            this.label8.Text = "Upcoming Events";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(490, 1327);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(117, 58);
            this.btnClear.TabIndex = 19;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.SteelBlue;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Location = new System.Drawing.Point(346, 1327);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(126, 58);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUpdate.Location = new System.Drawing.Point(194, 1327);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 58);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // ucExpenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "ucExpenseForm";
            this.Size = new System.Drawing.Size(1486, 1446);
            this.Load += new System.EventHandler(this.ucExpenseForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenses)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpenseEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnInsert;
        private Label label1;
        private Panel panel1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Panel panel2;
        private DataGridView dgvExpenseEvents;
        private Label label8;
        private Panel panel3;
        private TextBox txtName;
        private Label label5;
        private TextBox txtNotes;
        private DateTimePicker dtpStart;
        private Label label10;
        private Label label11;
        private Label label12;
        private TextBox txtAmount;
        private Label label13;
        private Panel panel4;
        private DataGridView dgvExpenses;
        private Label label2;
    }
}
