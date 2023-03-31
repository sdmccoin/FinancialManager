namespace FinancialManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBtnIncome = new System.Windows.Forms.ToolStripButton();
            this.txBtnExpense = new System.Windows.Forms.ToolStripButton();
            this.txBtnInvestments = new System.Windows.Forms.ToolStripButton();
            this.tsBtnReports = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlAlerts = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReports = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInvestments = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExpense = new System.Windows.Forms.Button();
            this.btnIncome = new System.Windows.Forms.Button();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnlLeft.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnIncome,
            this.txBtnExpense,
            this.txBtnInvestments,
            this.tsBtnReports});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(323, 51);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnIncome
            // 
            this.tsBtnIncome.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tsBtnIncome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnIncome.Image = global::FinancialManager.Properties.Resources.AddIncome;
            this.tsBtnIncome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnIncome.Name = "tsBtnIncome";
            this.tsBtnIncome.Size = new System.Drawing.Size(58, 44);
            this.tsBtnIncome.Text = "Income";
            this.tsBtnIncome.Click += new System.EventHandler(this.tsBtnIncome_Click);
            // 
            // txBtnExpense
            // 
            this.txBtnExpense.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txBtnExpense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txBtnExpense.Image = global::FinancialManager.Properties.Resources.ExpenseIcon2;
            this.txBtnExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txBtnExpense.Name = "txBtnExpense";
            this.txBtnExpense.Size = new System.Drawing.Size(58, 44);
            this.txBtnExpense.Text = "Expenses";
            this.txBtnExpense.Click += new System.EventHandler(this.txBtnExpense_Click);
            // 
            // txBtnInvestments
            // 
            this.txBtnInvestments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txBtnInvestments.Image = global::FinancialManager.Properties.Resources.investicon3;
            this.txBtnInvestments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txBtnInvestments.Name = "txBtnInvestments";
            this.txBtnInvestments.Size = new System.Drawing.Size(58, 44);
            this.txBtnInvestments.Text = "Investments";
            this.txBtnInvestments.Click += new System.EventHandler(this.tsBtnInvestments_Click);
            // 
            // tsBtnReports
            // 
            this.tsBtnReports.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnReports.Image = global::FinancialManager.Properties.Resources.ReportIcon1;
            this.tsBtnReports.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnReports.Name = "tsBtnReports";
            this.tsBtnReports.Size = new System.Drawing.Size(58, 44);
            this.tsBtnReports.Text = "Reports";
            this.tsBtnReports.Click += new System.EventHandler(this.tsBtnReports_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1817, 51);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(87, 45);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(244, 54);
            this.exitToolStripMenuItem.Text = "New";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(293, 54);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(244, 54);
            this.exitToolStripMenuItem1.Text = "Edit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(244, 54);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(106, 45);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(149, 45);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlLeft.Controls.Add(this.panel1);
            this.pnlLeft.Controls.Add(this.toolStrip1);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 51);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(323, 1589);
            this.pnlLeft.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pnlAlerts);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnInvestments);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnExpense);
            this.panel1.Controls.Add(this.btnIncome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(323, 1446);
            this.panel1.TabIndex = 1;
            // 
            // pnlAlerts
            // 
            this.pnlAlerts.Location = new System.Drawing.Point(67, 1355);
            this.pnlAlerts.Name = "pnlAlerts";
            this.pnlAlerts.Size = new System.Drawing.Size(217, 45);
            this.pnlAlerts.TabIndex = 2;
            this.pnlAlerts.Click += new System.EventHandler(this.pnlAlerts_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(-6, 1225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(323, 51);
            this.label4.TabIndex = 8;
            this.label4.Text = "Reports";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnReports.BackgroundImage = global::FinancialManager.Properties.Resources.ReportIcon1;
            this.btnReports.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReports.Location = new System.Drawing.Point(78, 1075);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(169, 129);
            this.btnReports.TabIndex = 7;
            this.btnReports.UseVisualStyleBackColor = false;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(-5, 851);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 51);
            this.label3.TabIndex = 6;
            this.label3.Text = "Investments";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnInvestments
            // 
            this.btnInvestments.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnInvestments.BackgroundImage = global::FinancialManager.Properties.Resources.investicon3;
            this.btnInvestments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInvestments.Location = new System.Drawing.Point(78, 709);
            this.btnInvestments.Name = "btnInvestments";
            this.btnInvestments.Size = new System.Drawing.Size(169, 154);
            this.btnInvestments.TabIndex = 5;
            this.btnInvestments.UseVisualStyleBackColor = false;
            this.btnInvestments.Click += new System.EventHandler(this.btnInvestments_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(-5, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Expenses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(-2, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 51);
            this.label1.TabIndex = 3;
            this.label1.Text = "Income";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExpense
            // 
            this.btnExpense.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExpense.BackgroundImage = global::FinancialManager.Properties.Resources.ExpenseIcon2;
            this.btnExpense.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpense.Location = new System.Drawing.Point(78, 386);
            this.btnExpense.Name = "btnExpense";
            this.btnExpense.Size = new System.Drawing.Size(169, 146);
            this.btnExpense.TabIndex = 2;
            this.btnExpense.UseVisualStyleBackColor = false;
            this.btnExpense.Click += new System.EventHandler(this.btnExpense_Click);
            // 
            // btnIncome
            // 
            this.btnIncome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIncome.BackgroundImage = global::FinancialManager.Properties.Resources.AddIncome;
            this.btnIncome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIncome.Location = new System.Drawing.Point(78, 100);
            this.btnIncome.Name = "btnIncome";
            this.btnIncome.Size = new System.Drawing.Size(169, 130);
            this.btnIncome.TabIndex = 1;
            this.btnIncome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnIncome.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnIncome.UseVisualStyleBackColor = false;
            this.btnIncome.Click += new System.EventHandler(this.btnIncome_Click);
            // 
            // pnlBottom
            // 
            this.pnlBottom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(323, 1547);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(1494, 93);
            this.pnlBottom.TabIndex = 5;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlMain.Location = new System.Drawing.Point(323, 102);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1494, 1446);
            this.pnlMain.TabIndex = 6;
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            // 
            // backgroundWorker3
            // 
            this.backgroundWorker3.WorkerReportsProgress = true;
            this.backgroundWorker3.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork);
            this.backgroundWorker3.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker3_ProgressChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1817, 1640);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsBtnIncome;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripButton txBtnExpense;
        private Panel pnlLeft;
        private Panel pnlBottom;
        private Panel pnlMain;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem exitToolStripMenuItem2;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripButton txBtnInvestments;
        private ToolStripButton tsBtnReports;
        private Panel panel1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private Label label4;
        private Button btnReports;
        private Label label3;
        private Button btnInvestments;
        private Label label2;
        private Label label1;
        private Button btnExpense;
        private Button btnIncome;
        private Panel pnlAlerts;
    }
}