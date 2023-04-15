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
            this.components = new System.ComponentModel.Container();
            this.dgvInvestments = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dgvInvestmentsEvents = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.pnlDetails = new System.Windows.Forms.Panel();
            this.btnMoreInfo = new System.Windows.Forms.Button();
            this.pbxFourMonthAverageIndicator = new System.Windows.Forms.PictureBox();
            this.pbxYesterdayStockPriceIndicator = new System.Windows.Forms.PictureBox();
            this.pbxCurrentStockPriceIndicator = new System.Windows.Forms.PictureBox();
            this.lblFourMonthAveragePrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblYesterdayStockPrice = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCurrentStockPrice = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.lblt = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSymbol = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSymbol = new System.Windows.Forms.TextBox();
            this.btnStockSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestments)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestmentsEvents)).BeginInit();
            this.pnlDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFourMonthAverageIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYesterdayStockPriceIndicator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentStockPriceIndicator)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvInvestments
            // 
            this.dgvInvestments.AllowUserToAddRows = false;
            this.dgvInvestments.AllowUserToDeleteRows = false;
            this.dgvInvestments.AllowUserToResizeColumns = false;
            this.dgvInvestments.AllowUserToResizeRows = false;
            this.dgvInvestments.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInvestments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestments.Location = new System.Drawing.Point(48, 937);
            this.dgvInvestments.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvInvestments.MaximumSize = new System.Drawing.Size(1370, 364);
            this.dgvInvestments.MultiSelect = false;
            this.dgvInvestments.Name = "dgvInvestments";
            this.dgvInvestments.ReadOnly = true;
            this.dgvInvestments.RowHeadersVisible = false;
            this.dgvInvestments.RowHeadersWidth = 102;
            this.dgvInvestments.RowTemplate.Height = 49;
            this.dgvInvestments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvestments.Size = new System.Drawing.Size(1370, 364);
            this.dgvInvestments.TabIndex = 11;
            this.dgvInvestments.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInvestments_CellDoubleClick);
            this.dgvInvestments.SelectionChanged += new System.EventHandler(this.dgvInvestments_SelectionChanged);
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
            this.label1.Text = "Investments";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnAddStock);
            this.panel1.Controls.Add(this.pnlDetails);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.btnClear);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnUpdate);
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.dgvInvestments);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1486, 1446);
            this.panel1.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label10.Location = new System.Drawing.Point(48, 879);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1370, 56);
            this.label10.TabIndex = 41;
            this.label10.Text = "Current Investments";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dgvInvestmentsEvents);
            this.panel4.Location = new System.Drawing.Point(63, 638);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(639, 207);
            this.panel4.TabIndex = 39;
            // 
            // dgvInvestmentsEvents
            // 
            this.dgvInvestmentsEvents.AllowUserToAddRows = false;
            this.dgvInvestmentsEvents.AllowUserToDeleteRows = false;
            this.dgvInvestmentsEvents.AllowUserToResizeColumns = false;
            this.dgvInvestmentsEvents.AllowUserToResizeRows = false;
            this.dgvInvestmentsEvents.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvInvestmentsEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInvestmentsEvents.ColumnHeadersVisible = false;
            this.dgvInvestmentsEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvInvestmentsEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInvestmentsEvents.Location = new System.Drawing.Point(0, 0);
            this.dgvInvestmentsEvents.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.dgvInvestmentsEvents.MultiSelect = false;
            this.dgvInvestmentsEvents.Name = "dgvInvestmentsEvents";
            this.dgvInvestmentsEvents.ReadOnly = true;
            this.dgvInvestmentsEvents.RowHeadersVisible = false;
            this.dgvInvestmentsEvents.RowHeadersWidth = 102;
            this.dgvInvestmentsEvents.RowTemplate.Height = 49;
            this.dgvInvestmentsEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInvestmentsEvents.ShowCellErrors = false;
            this.dgvInvestmentsEvents.ShowCellToolTips = false;
            this.dgvInvestmentsEvents.ShowEditingIcon = false;
            this.dgvInvestmentsEvents.ShowRowErrors = false;
            this.dgvInvestmentsEvents.Size = new System.Drawing.Size(639, 207);
            this.dgvInvestmentsEvents.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(63, 584);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(639, 56);
            this.label5.TabIndex = 40;
            this.label5.Text = "Upcoming Events";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.SteelBlue;
            this.btnAddStock.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddStock.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddStock.Location = new System.Drawing.Point(976, 779);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(367, 66);
            this.btnAddStock.TabIndex = 4;
            this.btnAddStock.Text = "Add Stock to Portfolio";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.btnAddStock_Click);
            // 
            // pnlDetails
            // 
            this.pnlDetails.AutoScroll = true;
            this.pnlDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDetails.Controls.Add(this.btnMoreInfo);
            this.pnlDetails.Controls.Add(this.pbxFourMonthAverageIndicator);
            this.pnlDetails.Controls.Add(this.pbxYesterdayStockPriceIndicator);
            this.pnlDetails.Controls.Add(this.pbxCurrentStockPriceIndicator);
            this.pnlDetails.Controls.Add(this.lblFourMonthAveragePrice);
            this.pnlDetails.Controls.Add(this.label9);
            this.pnlDetails.Controls.Add(this.lblYesterdayStockPrice);
            this.pnlDetails.Controls.Add(this.label8);
            this.pnlDetails.Controls.Add(this.lblCurrentStockPrice);
            this.pnlDetails.Controls.Add(this.label7);
            this.pnlDetails.Controls.Add(this.lblStockType);
            this.pnlDetails.Controls.Add(this.lblt);
            this.pnlDetails.Controls.Add(this.lblName);
            this.pnlDetails.Controls.Add(this.label6);
            this.pnlDetails.Controls.Add(this.lblSymbol);
            this.pnlDetails.Controls.Add(this.label4);
            this.pnlDetails.Location = new System.Drawing.Point(913, 312);
            this.pnlDetails.Name = "pnlDetails";
            this.pnlDetails.Size = new System.Drawing.Size(488, 456);
            this.pnlDetails.TabIndex = 3;
            // 
            // btnMoreInfo
            // 
            this.btnMoreInfo.Location = new System.Drawing.Point(398, 0);
            this.btnMoreInfo.Name = "btnMoreInfo";
            this.btnMoreInfo.Size = new System.Drawing.Size(82, 58);
            this.btnMoreInfo.TabIndex = 21;
            this.toolTip1.SetToolTip(this.btnMoreInfo, "View More Financial Details About This Stock");
            this.btnMoreInfo.UseVisualStyleBackColor = true;
            this.btnMoreInfo.Click += new System.EventHandler(this.btnMoreInfo_Click);
            // 
            // pbxFourMonthAverageIndicator
            // 
            this.pbxFourMonthAverageIndicator.Location = new System.Drawing.Point(277, 362);
            this.pbxFourMonthAverageIndicator.Name = "pbxFourMonthAverageIndicator";
            this.pbxFourMonthAverageIndicator.Size = new System.Drawing.Size(30, 35);
            this.pbxFourMonthAverageIndicator.TabIndex = 17;
            this.pbxFourMonthAverageIndicator.TabStop = false;
            // 
            // pbxYesterdayStockPriceIndicator
            // 
            this.pbxYesterdayStockPriceIndicator.Location = new System.Drawing.Point(157, 304);
            this.pbxYesterdayStockPriceIndicator.Name = "pbxYesterdayStockPriceIndicator";
            this.pbxYesterdayStockPriceIndicator.Size = new System.Drawing.Size(30, 35);
            this.pbxYesterdayStockPriceIndicator.TabIndex = 16;
            this.pbxYesterdayStockPriceIndicator.TabStop = false;
            // 
            // pbxCurrentStockPriceIndicator
            // 
            this.pbxCurrentStockPriceIndicator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbxCurrentStockPriceIndicator.InitialImage = global::FinancialManager.Properties.Resources.stockup;
            this.pbxCurrentStockPriceIndicator.Location = new System.Drawing.Point(131, 245);
            this.pbxCurrentStockPriceIndicator.Name = "pbxCurrentStockPriceIndicator";
            this.pbxCurrentStockPriceIndicator.Size = new System.Drawing.Size(30, 35);
            this.pbxCurrentStockPriceIndicator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxCurrentStockPriceIndicator.TabIndex = 15;
            this.pbxCurrentStockPriceIndicator.TabStop = false;
            // 
            // lblFourMonthAveragePrice
            // 
            this.lblFourMonthAveragePrice.AutoSize = true;
            this.lblFourMonthAveragePrice.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFourMonthAveragePrice.Location = new System.Drawing.Point(325, 365);
            this.lblFourMonthAveragePrice.Name = "lblFourMonthAveragePrice";
            this.lblFourMonthAveragePrice.Size = new System.Drawing.Size(24, 32);
            this.lblFourMonthAveragePrice.TabIndex = 11;
            this.lblFourMonthAveragePrice.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(31, 365);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(232, 32);
            this.label9.TabIndex = 10;
            this.label9.Text = "Four Month Average:";
            // 
            // lblYesterdayStockPrice
            // 
            this.lblYesterdayStockPrice.AutoSize = true;
            this.lblYesterdayStockPrice.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYesterdayStockPrice.Location = new System.Drawing.Point(207, 304);
            this.lblYesterdayStockPrice.Name = "lblYesterdayStockPrice";
            this.lblYesterdayStockPrice.Size = new System.Drawing.Size(24, 32);
            this.lblYesterdayStockPrice.TabIndex = 9;
            this.lblYesterdayStockPrice.Text = "-";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(31, 307);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 32);
            this.label8.TabIndex = 8;
            this.label8.Text = "Yesterday:";
            // 
            // lblCurrentStockPrice
            // 
            this.lblCurrentStockPrice.AutoSize = true;
            this.lblCurrentStockPrice.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentStockPrice.Location = new System.Drawing.Point(181, 248);
            this.lblCurrentStockPrice.Name = "lblCurrentStockPrice";
            this.lblCurrentStockPrice.Size = new System.Drawing.Size(24, 32);
            this.lblCurrentStockPrice.TabIndex = 7;
            this.lblCurrentStockPrice.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(31, 248);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 32);
            this.label7.TabIndex = 6;
            this.label7.Text = "Current";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblStockType.Location = new System.Drawing.Point(135, 165);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(24, 32);
            this.lblStockType.TabIndex = 5;
            this.lblStockType.Text = "-";
            // 
            // lblt
            // 
            this.lblt.AutoSize = true;
            this.lblt.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblt.Location = new System.Drawing.Point(31, 165);
            this.lblt.Name = "lblt";
            this.lblt.Size = new System.Drawing.Size(69, 32);
            this.lblt.TabIndex = 4;
            this.lblt.Text = "Type:";
            // 
            // lblName
            // 
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(135, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(337, 63);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(31, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 32);
            this.label6.TabIndex = 2;
            this.label6.Text = "Name:";
            // 
            // lblSymbol
            // 
            this.lblSymbol.AutoSize = true;
            this.lblSymbol.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSymbol.Location = new System.Drawing.Point(135, 41);
            this.lblSymbol.Name = "lblSymbol";
            this.lblSymbol.Size = new System.Drawing.Size(24, 32);
            this.lblSymbol.TabIndex = 1;
            this.lblSymbol.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 7F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(31, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Symbol:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtSymbol);
            this.panel2.Controls.Add(this.btnStockSearch);
            this.panel2.Location = new System.Drawing.Point(913, 140);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(492, 89);
            this.panel2.TabIndex = 38;
            // 
            // txtSymbol
            // 
            this.txtSymbol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtSymbol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSymbol.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSymbol.Location = new System.Drawing.Point(14, 16);
            this.txtSymbol.Name = "txtSymbol";
            this.txtSymbol.Size = new System.Drawing.Size(312, 47);
            this.txtSymbol.TabIndex = 0;
            this.txtSymbol.TextChanged += new System.EventHandler(this.txtSymbol_TextChanged);
            // 
            // btnStockSearch
            // 
            this.btnStockSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStockSearch.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnStockSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStockSearch.Location = new System.Drawing.Point(347, 16);
            this.btnStockSearch.Name = "btnStockSearch";
            this.btnStockSearch.Size = new System.Drawing.Size(116, 47);
            this.btnStockSearch.TabIndex = 1;
            this.btnStockSearch.Text = "Search";
            this.btnStockSearch.UseVisualStyleBackColor = false;
            this.btnStockSearch.Click += new System.EventHandler(this.btnStockSearch_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(913, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(488, 48);
            this.label3.TabIndex = 2;
            this.label3.Text = "Details";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(913, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(488, 48);
            this.label2.TabIndex = 37;
            this.label2.Text = "Stock Search";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtName);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtNotes);
            this.panel3.Controls.Add(this.dtpStart);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.txtAmount);
            this.panel3.Location = new System.Drawing.Point(63, 138);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(694, 405);
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(13, 53);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 34);
            this.label12.TabIndex = 0;
            this.label12.Text = "Name";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(13, 193);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 34);
            this.label14.TabIndex = 31;
            this.label14.Text = "Notes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label15.Location = new System.Drawing.Point(13, 123);
            this.label15.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 34);
            this.label15.TabIndex = 27;
            this.label15.Text = "Amount";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(314, 125);
            this.label16.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(79, 34);
            this.label16.TabIndex = 29;
            this.label16.Text = "Date:";
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
            // label17
            // 
            this.label17.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(63, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(694, 48);
            this.label17.TabIndex = 36;
            this.label17.Text = "Source of Investment";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnClear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClear.Location = new System.Drawing.Point(489, 1350);
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
            this.btnDelete.Location = new System.Drawing.Point(345, 1350);
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
            this.btnUpdate.Location = new System.Drawing.Point(193, 1350);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(130, 58);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SteelBlue;
            this.btnInsert.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.btnInsert.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnInsert.Location = new System.Drawing.Point(48, 1350);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(123, 58);
            this.btnInsert.TabIndex = 16;
            this.btnInsert.Text = "Save";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // ucInvestmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(7, 8, 7, 8);
            this.Name = "ucInvestmentForm";
            this.Size = new System.Drawing.Size(1486, 1446);
            this.Load += new System.EventHandler(this.ucInvestmentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestments)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInvestmentsEvents)).EndInit();
            this.pnlDetails.ResumeLayout(false);
            this.pnlDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFourMonthAverageIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxYesterdayStockPriceIndicator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxCurrentStockPriceIndicator)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DataGridView dgvInvestments;
        private Label label1;
        private Panel panel1;
        private Button btnClear;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private Button btnAddStock;
        private Panel pnlDetails;
        private Label label3;
        private Button btnStockSearch;
        private TextBox txtSymbol;
        private Label lblSymbol;
        private Label label4;
        private Label lblName;
        private Label label6;
        private Label lblStockType;
        private Label lblt;
        private Label lblFourMonthAveragePrice;
        private Label label9;
        private Label lblYesterdayStockPrice;
        private Label label8;
        private Label lblCurrentStockPrice;
        private Label label7;
        private PictureBox pbxFourMonthAverageIndicator;
        private PictureBox pbxYesterdayStockPriceIndicator;
        private PictureBox pbxCurrentStockPriceIndicator;
        private Button btnMoreInfo;
        private ToolTip toolTip1;
        private Panel panel3;
        private TextBox txtName;
        private Label label12;
        private TextBox txtNotes;
        private DateTimePicker dtpStart;
        private Label label14;
        private Label label15;
        private Label label16;
        private TextBox txtAmount;
        private Label label17;
        private Panel panel2;
        private Label label2;
        private Panel panel4;
        private DataGridView dgvInvestmentsEvents;
        private Label label5;
        private Label label10;
    }
}
