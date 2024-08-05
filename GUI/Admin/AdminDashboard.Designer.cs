namespace ABCCarTraders.GUI.Admin
{
    partial class AdminDashboard
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
            this.manageBrandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarPartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCarPartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageAdminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.financialReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dailyIncomeReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderQuantityReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerRelatedReportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerOrderDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageBrandToolStripMenuItem,
            this.manageCarPartsToolStripMenuItem,
            this.manageUserToolStripMenuItem,
            this.manageOrderToolStripMenuItem,
            this.generateReportsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageBrandToolStripMenuItem
            // 
            this.manageBrandToolStripMenuItem.Name = "manageBrandToolStripMenuItem";
            this.manageBrandToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.manageBrandToolStripMenuItem.Text = "Manage Brands";
            this.manageBrandToolStripMenuItem.Click += new System.EventHandler(this.manageCarToolStripMenuItem_Click_1);
            // 
            // manageCarPartsToolStripMenuItem
            // 
            this.manageCarPartsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageCarToolStripMenuItem1,
            this.manageCarPartToolStripMenuItem});
            this.manageCarPartsToolStripMenuItem.Name = "manageCarPartsToolStripMenuItem";
            this.manageCarPartsToolStripMenuItem.Size = new System.Drawing.Size(117, 24);
            this.manageCarPartsToolStripMenuItem.Text = "Manage Items";
            // 
            // manageCarToolStripMenuItem1
            // 
            this.manageCarToolStripMenuItem1.Name = "manageCarToolStripMenuItem1";
            this.manageCarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.manageCarToolStripMenuItem1.Text = "Manage Car";
            this.manageCarToolStripMenuItem1.Click += new System.EventHandler(this.manageCarToolStripMenuItem1_Click_1);
            // 
            // manageCarPartToolStripMenuItem
            // 
            this.manageCarPartToolStripMenuItem.Name = "manageCarPartToolStripMenuItem";
            this.manageCarPartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manageCarPartToolStripMenuItem.Text = "Manage Car Part";
            this.manageCarPartToolStripMenuItem.Click += new System.EventHandler(this.manageCarPartToolStripMenuItem_Click_1);
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageAdminToolStripMenuItem,
            this.manageCustomerToolStripMenuItem});
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            // 
            // manageAdminToolStripMenuItem
            // 
            this.manageAdminToolStripMenuItem.Name = "manageAdminToolStripMenuItem";
            this.manageAdminToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.manageAdminToolStripMenuItem.Text = "Manage Admin";
            // 
            // manageCustomerToolStripMenuItem
            // 
            this.manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            this.manageCustomerToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.manageCustomerToolStripMenuItem.Text = "Manage Customer";
            // 
            // manageOrderToolStripMenuItem
            // 
            this.manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
            this.manageOrderToolStripMenuItem.Size = new System.Drawing.Size(119, 24);
            this.manageOrderToolStripMenuItem.Text = "Manage Order";
            // 
            // generateReportsToolStripMenuItem
            // 
            this.generateReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financialReportToolStripMenuItem,
            this.inventoryReportToolStripMenuItem,
            this.dailyIncomeReportToolStripMenuItem,
            this.orderQuantityReportToolStripMenuItem,
            this.customerRelatedReportsToolStripMenuItem});
            this.generateReportsToolStripMenuItem.Name = "generateReportsToolStripMenuItem";
            this.generateReportsToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.generateReportsToolStripMenuItem.Text = "Generate Reports";
            // 
            // financialReportToolStripMenuItem
            // 
            this.financialReportToolStripMenuItem.Name = "financialReportToolStripMenuItem";
            this.financialReportToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.financialReportToolStripMenuItem.Text = "Financial Report";
            // 
            // inventoryReportToolStripMenuItem
            // 
            this.inventoryReportToolStripMenuItem.Name = "inventoryReportToolStripMenuItem";
            this.inventoryReportToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.inventoryReportToolStripMenuItem.Text = "Inventory Report";
            // 
            // dailyIncomeReportToolStripMenuItem
            // 
            this.dailyIncomeReportToolStripMenuItem.Name = "dailyIncomeReportToolStripMenuItem";
            this.dailyIncomeReportToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.dailyIncomeReportToolStripMenuItem.Text = "Daily Income Report";
            // 
            // orderQuantityReportToolStripMenuItem
            // 
            this.orderQuantityReportToolStripMenuItem.Name = "orderQuantityReportToolStripMenuItem";
            this.orderQuantityReportToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.orderQuantityReportToolStripMenuItem.Text = "Order Quantity Report";
            // 
            // customerRelatedReportsToolStripMenuItem
            // 
            this.customerRelatedReportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerDetailsToolStripMenuItem,
            this.customerOrderDetailsToolStripMenuItem});
            this.customerRelatedReportsToolStripMenuItem.Name = "customerRelatedReportsToolStripMenuItem";
            this.customerRelatedReportsToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.customerRelatedReportsToolStripMenuItem.Text = "Customer Related Reports";
            // 
            // customerDetailsToolStripMenuItem
            // 
            this.customerDetailsToolStripMenuItem.Name = "customerDetailsToolStripMenuItem";
            this.customerDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.customerDetailsToolStripMenuItem.Text = "Customer Details";
            // 
            // customerOrderDetailsToolStripMenuItem
            // 
            this.customerOrderDetailsToolStripMenuItem.Name = "customerOrderDetailsToolStripMenuItem";
            this.customerOrderDetailsToolStripMenuItem.Size = new System.Drawing.Size(247, 26);
            this.customerOrderDetailsToolStripMenuItem.Text = "Customer Order Details";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click_1);
            // 
            // AdminDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageBrandToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCarPartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manageCarPartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageAdminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem financialReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dailyIncomeReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderQuantityReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerRelatedReportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerOrderDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}