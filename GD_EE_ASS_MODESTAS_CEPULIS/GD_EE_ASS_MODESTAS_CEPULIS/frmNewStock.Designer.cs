namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmNewStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewStock));
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.pcmAddNewStock = new System.Windows.Forms.PictureBox();
            this.lblAmountOfItems = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblDateStockIsAdded = new System.Windows.Forms.Label();
            this.lblStockType = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbStockType = new System.Windows.Forms.TextBox();
            this.tbAmountOfItems = new System.Windows.Forms.TextBox();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcmAddNewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(800, 24);
            this.mnsGoBack.TabIndex = 11;
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
            // pcmAddNewStock
            // 
            this.pcmAddNewStock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcmAddNewStock.BackgroundImage")));
            this.pcmAddNewStock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcmAddNewStock.Location = new System.Drawing.Point(316, 27);
            this.pcmAddNewStock.Name = "pcmAddNewStock";
            this.pcmAddNewStock.Size = new System.Drawing.Size(136, 112);
            this.pcmAddNewStock.TabIndex = 70;
            this.pcmAddNewStock.TabStop = false;
            // 
            // lblAmountOfItems
            // 
            this.lblAmountOfItems.AutoSize = true;
            this.lblAmountOfItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountOfItems.Location = new System.Drawing.Point(411, 191);
            this.lblAmountOfItems.Name = "lblAmountOfItems";
            this.lblAmountOfItems.Size = new System.Drawing.Size(147, 16);
            this.lblAmountOfItems.TabIndex = 83;
            this.lblAmountOfItems.Text = "The amount of items";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(275, 282);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 82;
            // 
            // lblDateStockIsAdded
            // 
            this.lblDateStockIsAdded.AutoSize = true;
            this.lblDateStockIsAdded.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateStockIsAdded.Location = new System.Drawing.Point(274, 263);
            this.lblDateStockIsAdded.Name = "lblDateStockIsAdded";
            this.lblDateStockIsAdded.Size = new System.Drawing.Size(201, 16);
            this.lblDateStockIsAdded.TabIndex = 81;
            this.lblDateStockIsAdded.Text = "The date the stock is added";
            // 
            // lblStockType
            // 
            this.lblStockType.AutoSize = true;
            this.lblStockType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockType.Location = new System.Drawing.Point(212, 191);
            this.lblStockType.Name = "lblStockType";
            this.lblStockType.Size = new System.Drawing.Size(110, 16);
            this.lblStockType.TabIndex = 80;
            this.lblStockType.Text = "The stock type";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.White;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Location = new System.Drawing.Point(340, 322);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(70, 28);
            this.btnAdd.TabIndex = 86;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbStockType
            // 
            this.tbStockType.Location = new System.Drawing.Point(194, 210);
            this.tbStockType.MaxLength = 20;
            this.tbStockType.Name = "tbStockType";
            this.tbStockType.Size = new System.Drawing.Size(143, 20);
            this.tbStockType.TabIndex = 87;
            // 
            // tbAmountOfItems
            // 
            this.tbAmountOfItems.Location = new System.Drawing.Point(405, 210);
            this.tbAmountOfItems.MaxLength = 20;
            this.tbAmountOfItems.Name = "tbAmountOfItems";
            this.tbAmountOfItems.Size = new System.Drawing.Size(163, 20);
            this.tbAmountOfItems.TabIndex = 88;
            // 
            // frmNewStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbAmountOfItems);
            this.Controls.Add(this.tbStockType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAmountOfItems);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.lblDateStockIsAdded);
            this.Controls.Add(this.lblStockType);
            this.Controls.Add(this.pcmAddNewStock);
            this.Controls.Add(this.mnsGoBack);
            this.Name = "frmNewStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Stock";
            this.Load += new System.EventHandler(this.frmNewStock_Load);
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcmAddNewStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.PictureBox pcmAddNewStock;
        private System.Windows.Forms.Label lblAmountOfItems;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblDateStockIsAdded;
        private System.Windows.Forms.Label lblStockType;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbStockType;
        private System.Windows.Forms.TextBox tbAmountOfItems;
    }
}