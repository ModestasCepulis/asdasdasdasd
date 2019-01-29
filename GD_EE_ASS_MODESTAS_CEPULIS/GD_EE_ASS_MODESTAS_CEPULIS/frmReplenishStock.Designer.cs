namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmReplenishStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReplenishStock));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrder = new System.Windows.Forms.Button();
            this.cmbStockType = new System.Windows.Forms.ComboBox();
            this.lblAmountOfItems = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.pcbReplenishStock = new System.Windows.Forms.PictureBox();
            this.tbAmountOfItems = new System.Windows.Forms.TextBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReplenishStock)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(800, 24);
            this.mnsGoBack.TabIndex = 28;
            this.mnsGoBack.Text = "menuStrip1";
            // 
            // tlmnuGoBack
            // 
            this.tlmnuGoBack.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuBack});
            this.tlmnuGoBack.Name = "tlmnuGoBack";
            this.tlmnuGoBack.Size = new System.Drawing.Size(62, 20);
            this.tlmnuGoBack.Text = "Go back";
            // 
            // tlmnuBack
            // 
            this.tlmnuBack.Name = "tlmnuBack";
            this.tlmnuBack.Size = new System.Drawing.Size(99, 22);
            this.tlmnuBack.Text = "Back";
            this.tlmnuBack.Click += new System.EventHandler(this.tlmnuBack_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.ForeColor = System.Drawing.Color.Black;
            this.btnOrder.Location = new System.Drawing.Point(352, 260);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(70, 28);
            this.btnOrder.TabIndex = 94;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // cmbStockType
            // 
            this.cmbStockType.FormattingEnabled = true;
            this.cmbStockType.Items.AddRange(new object[] {
            "Jeans",
            "Shirts"});
            this.cmbStockType.Location = new System.Drawing.Point(223, 220);
            this.cmbStockType.Name = "cmbStockType";
            this.cmbStockType.Size = new System.Drawing.Size(144, 21);
            this.cmbStockType.TabIndex = 92;
            this.cmbStockType.Text = "Jeans";
            // 
            // lblAmountOfItems
            // 
            this.lblAmountOfItems.AutoSize = true;
            this.lblAmountOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfItems.Location = new System.Drawing.Point(416, 191);
            this.lblAmountOfItems.Name = "lblAmountOfItems";
            this.lblAmountOfItems.Size = new System.Drawing.Size(147, 16);
            this.lblAmountOfItems.TabIndex = 91;
            this.lblAmountOfItems.Text = "The amount of items";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockType.Location = new System.Drawing.Point(217, 191);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(110, 16);
            this.lblStockType.TabIndex = 88;
            this.lblStockType.Text = "The stock type";
            // 
            // pcbReplenishStock
            // 
            this.pcbReplenishStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbReplenishStock.BackgroundImage")));
            this.pcbReplenishStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbReplenishStock.Location = new System.Drawing.Point(321, 27);
            this.pcbReplenishStock.Name = "pcbReplenishStock";
            this.pcbReplenishStock.Size = new System.Drawing.Size(136, 112);
            this.pcbReplenishStock.TabIndex = 87;
            this.pcbReplenishStock.TabStop = false;
            // 
            // tbAmountOfItems
            // 
            this.tbAmountOfItems.Location = new System.Drawing.Point(410, 221);
            this.tbAmountOfItems.MaxLength = 20;
            this.tbAmountOfItems.Name = "tbAmountOfItems";
            this.tbAmountOfItems.Size = new System.Drawing.Size(163, 20);
            this.tbAmountOfItems.TabIndex = 95;
            // 
            // frmReplenishStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAmountOfItems);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.cmbStockType);
            this.Controls.Add(this.lblAmountOfItems);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.pcbReplenishStock);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmReplenishStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Replenish Stock";
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReplenishStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.ComboBox cmbStockType;
        private System.Windows.Forms.Label lblAmountOfItems;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.PictureBox pcbReplenishStock;
        private System.Windows.Forms.TextBox tbAmountOfItems;
    }
}