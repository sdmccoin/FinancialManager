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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.txBtnInvestments = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBtnIncome,
            this.txBtnExpense,
            this.txBtnInvestments});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.toolStrip1.Size = new System.Drawing.Size(748, 47);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnIncome
            // 
            this.tsBtnIncome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsBtnIncome.Image = global::FinancialManager.Properties.Resources.IncomeImage2;
            this.tsBtnIncome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBtnIncome.Name = "tsBtnIncome";
            this.tsBtnIncome.Size = new System.Drawing.Size(44, 44);
            this.tsBtnIncome.Text = "Income";
            this.tsBtnIncome.Click += new System.EventHandler(this.tsBtnIncome_Click);
            // 
            // txBtnExpense
            // 
            this.txBtnExpense.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txBtnExpense.Image = global::FinancialManager.Properties.Resources.Expense2;
            this.txBtnExpense.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txBtnExpense.Name = "txBtnExpense";
            this.txBtnExpense.Size = new System.Drawing.Size(44, 44);
            this.txBtnExpense.Text = "Expenses";
            this.txBtnExpense.Click += new System.EventHandler(this.txBtnExpense_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(2, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(748, 24);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem.Text = "New";
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.accountToolStripMenuItem.Text = "Account";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem1.Text = "Edit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(98, 22);
            this.exitToolStripMenuItem2.Text = "Exit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // pnlLeft
            // 
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 71);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(1);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(133, 479);
            this.pnlLeft.TabIndex = 4;
            // 
            // pnlBottom
            // 
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(133, 517);
            this.pnlBottom.Margin = new System.Windows.Forms.Padding(1);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(615, 33);
            this.pnlBottom.TabIndex = 5;
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pnlMain.Location = new System.Drawing.Point(133, 71);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(1);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(612, 444);
            this.pnlMain.TabIndex = 6;
            // 
            // txBtnInvestments
            // 
            this.txBtnInvestments.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.txBtnInvestments.Image = global::FinancialManager.Properties.Resources.Investments;
            this.txBtnInvestments.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.txBtnInvestments.Name = "txBtnInvestments";
            this.txBtnInvestments.Size = new System.Drawing.Size(44, 44);
            this.txBtnInvestments.Text = "Investments";
            this.txBtnInvestments.Click += new System.EventHandler(this.tsBtnInvestments_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 550);
            this.Controls.Add(this.pnlBottom);
            this.Controls.Add(this.pnlLeft);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}