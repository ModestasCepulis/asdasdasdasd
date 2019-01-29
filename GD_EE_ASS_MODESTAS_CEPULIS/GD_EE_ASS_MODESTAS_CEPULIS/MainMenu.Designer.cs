﻿namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.mnsCustomers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnnsNewCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsChangeCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsRemoveCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsNewOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsChangeOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsDispatchOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsCancelOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsListDailyDeliveries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAnalyseOrders = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsAnalyseRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.stockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replenishStockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mgsMainMenu = new System.Windows.Forms.MenuStrip();
            this.mgsMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(348, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome";
            // 
            // mnsCustomers
            // 
            this.mnsCustomers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnnsNewCustomer,
            this.mnsChangeCustomer,
            this.mnsRemoveCustomer});
            this.mnsCustomers.Name = "mnsCustomers";
            this.mnsCustomers.Size = new System.Drawing.Size(76, 20);
            this.mnsCustomers.Text = "Customers";
            this.mnsCustomers.Click += new System.EventHandler(this.mnsCustomers_Click);
            // 
            // mnnsNewCustomer
            // 
            this.mnnsNewCustomer.Name = "mnnsNewCustomer";
            this.mnnsNewCustomer.Size = new System.Drawing.Size(209, 22);
            this.mnnsNewCustomer.Text = "New Customer";
            this.mnnsNewCustomer.Click += new System.EventHandler(this.newCustomerToolStripMenuItem_Click);
            // 
            // mnsChangeCustomer
            // 
            this.mnsChangeCustomer.Name = "mnsChangeCustomer";
            this.mnsChangeCustomer.Size = new System.Drawing.Size(209, 22);
            this.mnsChangeCustomer.Text = "Change Customer details";
            this.mnsChangeCustomer.Click += new System.EventHandler(this.mnsChangeCustomer_Click);
            // 
            // mnsRemoveCustomer
            // 
            this.mnsRemoveCustomer.Name = "mnsRemoveCustomer";
            this.mnsRemoveCustomer.Size = new System.Drawing.Size(209, 22);
            this.mnsRemoveCustomer.Text = "Remove Customer details";
            this.mnsRemoveCustomer.Click += new System.EventHandler(this.mnsRemoveCustomer_Click);
            // 
            // mnsOrders
            // 
            this.mnsOrders.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsNewOrder,
            this.mnsChangeOrder,
            this.mnsDispatchOrder,
            this.mnsCancelOrder});
            this.mnsOrders.Name = "mnsOrders";
            this.mnsOrders.Size = new System.Drawing.Size(54, 20);
            this.mnsOrders.Text = "Orders";
            // 
            // mnsNewOrder
            // 
            this.mnsNewOrder.Name = "mnsNewOrder";
            this.mnsNewOrder.Size = new System.Drawing.Size(180, 22);
            this.mnsNewOrder.Text = "New Order";
            this.mnsNewOrder.Click += new System.EventHandler(this.newOrderToolStripMenuItem_Click);
            // 
            // mnsChangeOrder
            // 
            this.mnsChangeOrder.Name = "mnsChangeOrder";
            this.mnsChangeOrder.Size = new System.Drawing.Size(180, 22);
            this.mnsChangeOrder.Text = "Change Order";
            this.mnsChangeOrder.Click += new System.EventHandler(this.mnsChangeOrder_Click);
            // 
            // mnsDispatchOrder
            // 
            this.mnsDispatchOrder.Name = "mnsDispatchOrder";
            this.mnsDispatchOrder.Size = new System.Drawing.Size(180, 22);
            this.mnsDispatchOrder.Text = "Dispatch Order";
            this.mnsDispatchOrder.Click += new System.EventHandler(this.mnsDispatchOrder_Click);
            // 
            // mnsCancelOrder
            // 
            this.mnsCancelOrder.Name = "mnsCancelOrder";
            this.mnsCancelOrder.Size = new System.Drawing.Size(180, 22);
            this.mnsCancelOrder.Text = "Cancel Order";
            this.mnsCancelOrder.Click += new System.EventHandler(this.mnsCancelOrder_Click);
            // 
            // mnsAdmin
            // 
            this.mnsAdmin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsListDailyDeliveries,
            this.mnsAnalyseOrders,
            this.mnsAnalyseRevenue});
            this.mnsAdmin.Name = "mnsAdmin";
            this.mnsAdmin.Size = new System.Drawing.Size(55, 20);
            this.mnsAdmin.Text = "Admin";
            // 
            // mnsListDailyDeliveries
            // 
            this.mnsListDailyDeliveries.Name = "mnsListDailyDeliveries";
            this.mnsListDailyDeliveries.Size = new System.Drawing.Size(180, 22);
            this.mnsListDailyDeliveries.Text = "Analyse deliveries";
            this.mnsListDailyDeliveries.Click += new System.EventHandler(this.mnsListDailyDeliveries_Click);
            // 
            // mnsAnalyseOrders
            // 
            this.mnsAnalyseOrders.Name = "mnsAnalyseOrders";
            this.mnsAnalyseOrders.Size = new System.Drawing.Size(180, 22);
            this.mnsAnalyseOrders.Text = "Analyse orders";
            this.mnsAnalyseOrders.Click += new System.EventHandler(this.mnsAnalyseOrders_Click);
            // 
            // mnsAnalyseRevenue
            // 
            this.mnsAnalyseRevenue.Name = "mnsAnalyseRevenue";
            this.mnsAnalyseRevenue.Size = new System.Drawing.Size(180, 22);
            this.mnsAnalyseRevenue.Text = "Analyse revenue";
            this.mnsAnalyseRevenue.Click += new System.EventHandler(this.mnsAnalyseRevenue_Click);
            // 
            // stockToolStripMenuItem
            // 
            this.stockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newStockToolStripMenuItem,
            this.replenishStockToolStripMenuItem});
            this.stockToolStripMenuItem.Name = "stockToolStripMenuItem";
            this.stockToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.stockToolStripMenuItem.Text = "Stock";
            // 
            // newStockToolStripMenuItem
            // 
            this.newStockToolStripMenuItem.Name = "newStockToolStripMenuItem";
            this.newStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newStockToolStripMenuItem.Text = "New Stock";
            this.newStockToolStripMenuItem.Click += new System.EventHandler(this.newStockToolStripMenuItem_Click);
            // 
            // replenishStockToolStripMenuItem
            // 
            this.replenishStockToolStripMenuItem.Name = "replenishStockToolStripMenuItem";
            this.replenishStockToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.replenishStockToolStripMenuItem.Text = "Replenish Stock";
            this.replenishStockToolStripMenuItem.Click += new System.EventHandler(this.replenishStockToolStripMenuItem_Click);
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginMenuToolStripMenuItem});
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // loginMenuToolStripMenuItem
            // 
            this.loginMenuToolStripMenuItem.Name = "loginMenuToolStripMenuItem";
            this.loginMenuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loginMenuToolStripMenuItem.Text = "Login menu";
            this.loginMenuToolStripMenuItem.Click += new System.EventHandler(this.loginMenuToolStripMenuItem_Click);
            // 
            // mgsMainMenu
            // 
            this.mgsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsCustomers,
            this.mnsOrders,
            this.stockToolStripMenuItem,
            this.mnsAdmin,
            this.loginToolStripMenuItem});
            this.mgsMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mgsMainMenu.Name = "mgsMainMenu";
            this.mgsMainMenu.Size = new System.Drawing.Size(1077, 24);
            this.mgsMainMenu.TabIndex = 1;
            this.mgsMainMenu.Text = "menuStrip1";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1077, 622);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mgsMainMenu);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.mgsMainMenu;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.mgsMainMenu.ResumeLayout(false);
            this.mgsMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem mnsCustomers;
        private System.Windows.Forms.ToolStripMenuItem mnnsNewCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnsChangeCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnsRemoveCustomer;
        private System.Windows.Forms.ToolStripMenuItem mnsOrders;
        private System.Windows.Forms.ToolStripMenuItem mnsNewOrder;
        private System.Windows.Forms.ToolStripMenuItem mnsChangeOrder;
        private System.Windows.Forms.ToolStripMenuItem mnsDispatchOrder;
        private System.Windows.Forms.ToolStripMenuItem mnsCancelOrder;
        private System.Windows.Forms.ToolStripMenuItem mnsAdmin;
        private System.Windows.Forms.ToolStripMenuItem mnsListDailyDeliveries;
        private System.Windows.Forms.ToolStripMenuItem mnsAnalyseOrders;
        private System.Windows.Forms.ToolStripMenuItem mnsAnalyseRevenue;
        private System.Windows.Forms.ToolStripMenuItem stockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem replenishStockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginMenuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip mgsMainMenu;
    }
}

