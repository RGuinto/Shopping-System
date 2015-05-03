namespace WindowsFormsApplication1
{
    partial class Admin
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageAccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateAccountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pastPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.totalPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createReportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAccountsToolStripMenuItem,
            this.pastPurchasesToolStripMenuItem,
            this.totalPurchasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(360, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageAccountsToolStripMenuItem
            // 
            this.manageAccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createAccountToolStripMenuItem,
            this.updateAccountToolStripMenuItem});
            this.manageAccountsToolStripMenuItem.Name = "manageAccountsToolStripMenuItem";
            this.manageAccountsToolStripMenuItem.Size = new System.Drawing.Size(115, 20);
            this.manageAccountsToolStripMenuItem.Text = "Manage Accounts";
            this.manageAccountsToolStripMenuItem.Click += new System.EventHandler(this.manageAccountsToolStripMenuItem_Click);
            // 
            // createAccountToolStripMenuItem
            // 
            this.createAccountToolStripMenuItem.Name = "createAccountToolStripMenuItem";
            this.createAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.createAccountToolStripMenuItem.Text = "Create Account";
            this.createAccountToolStripMenuItem.Click += new System.EventHandler(this.createAccountToolStripMenuItem_Click);
            // 
            // updateAccountToolStripMenuItem
            // 
            this.updateAccountToolStripMenuItem.Name = "updateAccountToolStripMenuItem";
            this.updateAccountToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.updateAccountToolStripMenuItem.Text = "Update Account";
            this.updateAccountToolStripMenuItem.Click += new System.EventHandler(this.updateAccountToolStripMenuItem_Click);
            // 
            // pastPurchasesToolStripMenuItem
            // 
            this.pastPurchasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportToolStripMenuItem});
            this.pastPurchasesToolStripMenuItem.Name = "pastPurchasesToolStripMenuItem";
            this.pastPurchasesToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.pastPurchasesToolStripMenuItem.Text = "Past Purchases";
            this.pastPurchasesToolStripMenuItem.Click += new System.EventHandler(this.pastPurchasesToolStripMenuItem_Click);
            // 
            // createReportToolStripMenuItem
            // 
            this.createReportToolStripMenuItem.Name = "createReportToolStripMenuItem";
            this.createReportToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.createReportToolStripMenuItem.Text = "Create Report";
            this.createReportToolStripMenuItem.Click += new System.EventHandler(this.createReportToolStripMenuItem_Click);
            // 
            // totalPurchasesToolStripMenuItem
            // 
            this.totalPurchasesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createReportToolStripMenuItem1});
            this.totalPurchasesToolStripMenuItem.Name = "totalPurchasesToolStripMenuItem";
            this.totalPurchasesToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.totalPurchasesToolStripMenuItem.Text = "Total Purchases";
            this.totalPurchasesToolStripMenuItem.Click += new System.EventHandler(this.totalPurchasesToolStripMenuItem_Click);
            // 
            // createReportToolStripMenuItem1
            // 
            this.createReportToolStripMenuItem1.Name = "createReportToolStripMenuItem1";
            this.createReportToolStripMenuItem1.Size = new System.Drawing.Size(146, 22);
            this.createReportToolStripMenuItem1.Text = "Create Report";
            this.createReportToolStripMenuItem1.Click += new System.EventHandler(this.createReportToolStripMenuItem1_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 331);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageAccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateAccountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pastPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem totalPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createReportToolStripMenuItem1;

    }
}