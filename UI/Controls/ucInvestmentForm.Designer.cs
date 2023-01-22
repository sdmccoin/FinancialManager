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
            this.btnAddStock = new System.Windows.Forms.Button();
            this.dgvIncome = new System.Windows.Forms.DataGridView();
            this.pnlGoogleMaps = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpStock = new System.Windows.Forms.TabPage();
            this.tpBond = new System.Windows.Forms.TabPage();
            this.tp401k = new System.Windows.Forms.TabPage();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtAddress1 = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddBond = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAdd401k = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpStock.SuspendLayout();
            this.tpBond.SuspendLayout();
            this.tp401k.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(128, 106);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(75, 23);
            this.btnAddStock.TabIndex = 12;
            this.btnAddStock.Text = "Add Stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            // 
            // dgvIncome
            // 
            this.dgvIncome.AllowUserToAddRows = false;
            this.dgvIncome.AllowUserToDeleteRows = false;
            this.dgvIncome.AllowUserToResizeRows = false;
            this.dgvIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncome.Location = new System.Drawing.Point(22, 311);
            this.dgvIncome.Margin = new System.Windows.Forms.Padding(1);
            this.dgvIncome.MultiSelect = false;
            this.dgvIncome.Name = "dgvIncome";
            this.dgvIncome.ReadOnly = true;
            this.dgvIncome.RowHeadersVisible = false;
            this.dgvIncome.RowHeadersWidth = 102;
            this.dgvIncome.RowTemplate.Height = 49;
            this.dgvIncome.Size = new System.Drawing.Size(535, 126);
            this.dgvIncome.TabIndex = 11;
            // 
            // pnlGoogleMaps
            // 
            this.pnlGoogleMaps.Location = new System.Drawing.Point(308, 44);
            this.pnlGoogleMaps.Name = "pnlGoogleMaps";
            this.pnlGoogleMaps.Size = new System.Drawing.Size(249, 221);
            this.pnlGoogleMaps.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(611, 34);
            this.label1.TabIndex = 11;
            this.label1.Text = "Investments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Location = new System.Drawing.Point(22, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 259);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Source of Income";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvIncome);
            this.panel1.Controls.Add(this.pnlGoogleMaps);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(611, 503);
            this.panel1.TabIndex = 12;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpStock);
            this.tabControl1.Controls.Add(this.tpBond);
            this.tabControl1.Controls.Add(this.tp401k);
            this.tabControl1.Location = new System.Drawing.Point(6, 38);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(242, 214);
            this.tabControl1.TabIndex = 12;
            // 
            // tpStock
            // 
            this.tpStock.Controls.Add(this.btnAddStock);
            this.tpStock.Controls.Add(this.txtAmount);
            this.tpStock.Controls.Add(this.txtAddress1);
            this.tpStock.Controls.Add(this.txtName);
            this.tpStock.Controls.Add(this.label4);
            this.tpStock.Controls.Add(this.label3);
            this.tpStock.Controls.Add(this.label2);
            this.tpStock.Location = new System.Drawing.Point(4, 24);
            this.tpStock.Name = "tpStock";
            this.tpStock.Padding = new System.Windows.Forms.Padding(3);
            this.tpStock.Size = new System.Drawing.Size(234, 186);
            this.tpStock.TabIndex = 0;
            this.tpStock.Text = "Stock";
            this.tpStock.UseVisualStyleBackColor = true;
            // 
            // tpBond
            // 
            this.tpBond.Controls.Add(this.btnAddBond);
            this.tpBond.Controls.Add(this.textBox1);
            this.tpBond.Controls.Add(this.textBox2);
            this.tpBond.Controls.Add(this.textBox3);
            this.tpBond.Controls.Add(this.label5);
            this.tpBond.Controls.Add(this.label6);
            this.tpBond.Controls.Add(this.label7);
            this.tpBond.Location = new System.Drawing.Point(4, 24);
            this.tpBond.Name = "tpBond";
            this.tpBond.Padding = new System.Windows.Forms.Padding(3);
            this.tpBond.Size = new System.Drawing.Size(234, 186);
            this.tpBond.TabIndex = 1;
            this.tpBond.Text = "Bond";
            this.tpBond.UseVisualStyleBackColor = true;
            // 
            // tp401k
            // 
            this.tp401k.Controls.Add(this.btnAdd401k);
            this.tp401k.Controls.Add(this.textBox4);
            this.tp401k.Controls.Add(this.textBox5);
            this.tp401k.Controls.Add(this.textBox6);
            this.tp401k.Controls.Add(this.label8);
            this.tp401k.Controls.Add(this.label9);
            this.tp401k.Controls.Add(this.label10);
            this.tp401k.Location = new System.Drawing.Point(4, 24);
            this.tp401k.Name = "tp401k";
            this.tp401k.Size = new System.Drawing.Size(234, 186);
            this.tp401k.TabIndex = 2;
            this.tp401k.Text = "401k";
            this.tp401k.UseVisualStyleBackColor = true;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(83, 65);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(58, 23);
            this.txtAmount.TabIndex = 17;
            // 
            // txtAddress1
            // 
            this.txtAddress1.Location = new System.Drawing.Point(83, 36);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Size = new System.Drawing.Size(58, 23);
            this.txtAddress1.TabIndex = 16;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(83, 11);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Symbol";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Name";
            // 
            // btnAddBond
            // 
            this.btnAddBond.Location = new System.Drawing.Point(136, 112);
            this.btnAddBond.Name = "btnAddBond";
            this.btnAddBond.Size = new System.Drawing.Size(75, 23);
            this.btnAddBond.TabIndex = 18;
            this.btnAddBond.Text = "Add Bond";
            this.btnAddBond.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 71);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 23);
            this.textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(91, 42);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 23);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(91, 17);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 23);
            this.textBox3.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 21;
            this.label5.Text = "Amount";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 15);
            this.label6.TabIndex = 20;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Name";
            // 
            // btnAdd401k
            // 
            this.btnAdd401k.Location = new System.Drawing.Point(135, 111);
            this.btnAdd401k.Name = "btnAdd401k";
            this.btnAdd401k.Size = new System.Drawing.Size(75, 23);
            this.btnAdd401k.TabIndex = 18;
            this.btnAdd401k.Text = "Add 401k";
            this.btnAdd401k.UseVisualStyleBackColor = true;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 70);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(58, 23);
            this.textBox4.TabIndex = 24;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(90, 41);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(58, 23);
            this.textBox5.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(90, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 23);
            this.textBox6.TabIndex = 22;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(22, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Amount";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Symbol";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 15);
            this.label10.TabIndex = 19;
            this.label10.Text = "Name";
            // 
            // ucInvestmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "ucInvestmentForm";
            this.Size = new System.Drawing.Size(611, 503);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncome)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tpStock.ResumeLayout(false);
            this.tpStock.PerformLayout();
            this.tpBond.ResumeLayout(false);
            this.tpBond.PerformLayout();
            this.tp401k.ResumeLayout(false);
            this.tp401k.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnAddStock;
        private DataGridView dgvIncome;
        private Panel pnlGoogleMaps;
        private Label label1;
        private GroupBox groupBox1;
        private TabControl tabControl1;
        private TabPage tpStock;
        private TextBox txtAmount;
        private TextBox txtAddress1;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private TabPage tpBond;
        private Button btnAddBond;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private TabPage tp401k;
        private Button btnAdd401k;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label8;
        private Label label9;
        private Label label10;
        private Panel panel1;
    }
}
