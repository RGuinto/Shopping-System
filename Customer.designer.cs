namespace WindowsFormsApplication1
{
    partial class Customer
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
            this.createPurchaseOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reviewPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createPurchaseOrderToolStripMenuItem,
            this.reviewPurchasesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(399, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // createPurchaseOrderToolStripMenuItem
            // 
            this.createPurchaseOrderToolStripMenuItem.Name = "createPurchaseOrderToolStripMenuItem";
            this.createPurchaseOrderToolStripMenuItem.Size = new System.Drawing.Size(137, 20);
            this.createPurchaseOrderToolStripMenuItem.Text = "Create Purchase Order";
            this.createPurchaseOrderToolStripMenuItem.Click += new System.EventHandler(this.createPurchaseOrderToolStripMenuItem_Click);
            // 
            // reviewPurchasesToolStripMenuItem
            // 
            this.reviewPurchasesToolStripMenuItem.Name = "reviewPurchasesToolStripMenuItem";
            this.reviewPurchasesToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.reviewPurchasesToolStripMenuItem.Text = "Review Purchases";
            this.reviewPurchasesToolStripMenuItem.Click += new System.EventHandler(this.reviewPurchasesToolStripMenuItem_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 361);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem createPurchaseOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reviewPurchasesToolStripMenuItem;
    }
}