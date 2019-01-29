namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmNewOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewOrder));
            this.pcbAddNewOrder = new System.Windows.Forms.PictureBox();
            this.btnNewOrderAdd = new System.Windows.Forms.Button();
            this.lblOrderDeliveryDate1 = new System.Windows.Forms.Label();
            this.lblOrderAddress = new System.Windows.Forms.Label();
            this.tbOrderType = new System.Windows.Forms.TextBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblOrderDeliveryDate2 = new System.Windows.Forms.Label();
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tbEircode = new System.Windows.Forms.TextBox();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblItemsOrdered = new System.Windows.Forms.Label();
            this.dtgrvItems = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBasket = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.tbOrderID = new System.Windows.Forms.TextBox();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNewOrder)).BeginInit();
            this.mnsGoBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbAddNewOrder
            // 
            this.pcbAddNewOrder.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbAddNewOrder.BackgroundImage")));
            this.pcbAddNewOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pcbAddNewOrder.Location = new System.Drawing.Point(267, 54);
            this.pcbAddNewOrder.Name = "pcbAddNewOrder";
            this.pcbAddNewOrder.Size = new System.Drawing.Size(101, 84);
            this.pcbAddNewOrder.TabIndex = 1;
            this.pcbAddNewOrder.TabStop = false;
            // 
            // btnNewOrderAdd
            // 
            this.btnNewOrderAdd.BackColor = System.Drawing.Color.White;
            this.btnNewOrderAdd.ForeColor = System.Drawing.Color.Black;
            this.btnNewOrderAdd.Location = new System.Drawing.Point(234, 365);
            this.btnNewOrderAdd.Name = "btnNewOrderAdd";
            this.btnNewOrderAdd.Size = new System.Drawing.Size(163, 30);
            this.btnNewOrderAdd.TabIndex = 18;
            this.btnNewOrderAdd.Text = "Add";
            this.btnNewOrderAdd.UseVisualStyleBackColor = false;
            this.btnNewOrderAdd.Click += new System.EventHandler(this.btnNewOrderAdd_Click);
            // 
            // lblOrderDeliveryDate1
            // 
            this.lblOrderDeliveryDate1.AutoSize = true;
            this.lblOrderDeliveryDate1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDeliveryDate1.Location = new System.Drawing.Point(57, 249);
            this.lblOrderDeliveryDate1.Name = "lblOrderDeliveryDate1";
            this.lblOrderDeliveryDate1.Size = new System.Drawing.Size(259, 16);
            this.lblOrderDeliveryDate1.TabIndex = 16;
            this.lblOrderDeliveryDate1.Text = "Please enter the date when you want";
            // 
            // lblOrderAddress
            // 
            this.lblOrderAddress.AutoSize = true;
            this.lblOrderAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderAddress.Location = new System.Drawing.Point(335, 252);
            this.lblOrderAddress.Name = "lblOrderAddress";
            this.lblOrderAddress.Size = new System.Drawing.Size(242, 16);
            this.lblOrderAddress.TabIndex = 12;
            this.lblOrderAddress.Text = "Please enter the delivery address";
            // 
            // tbOrderType
            // 
            this.tbOrderType.Location = new System.Drawing.Point(82, 202);
            this.tbOrderType.MaxLength = 10;
            this.tbOrderType.Name = "tbOrderType";
            this.tbOrderType.Size = new System.Drawing.Size(200, 20);
            this.tbOrderType.TabIndex = 11;
            this.tbOrderType.TextChanged += new System.EventHandler(this.tbOrderType_TextChanged);
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderType.Location = new System.Drawing.Point(85, 172);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(196, 16);
            this.lblOrderType.TabIndex = 10;
            this.lblOrderType.Text = "Please enter the order type";
            // 
            // lblOrderDeliveryDate2
            // 
            this.lblOrderDeliveryDate2.AutoSize = true;
            this.lblOrderDeliveryDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDeliveryDate2.Location = new System.Drawing.Point(86, 265);
            this.lblOrderDeliveryDate2.Name = "lblOrderDeliveryDate2";
            this.lblOrderDeliveryDate2.Size = new System.Drawing.Size(179, 16);
            this.lblOrderDeliveryDate2.TabIndex = 19;
            this.lblOrderDeliveryDate2.Text = "the order to be delivered";
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(936, 24);
            this.mnsGoBack.TabIndex = 21;
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
            // tbEircode
            // 
            this.tbEircode.Location = new System.Drawing.Point(464, 305);
            this.tbEircode.MaxLength = 10;
            this.tbEircode.Name = "tbEircode";
            this.tbEircode.Size = new System.Drawing.Size(113, 20);
            this.tbEircode.TabIndex = 30;
            this.tbEircode.Text = "Eircode";
            // 
            // tbCounty
            // 
            this.tbCounty.Location = new System.Drawing.Point(338, 305);
            this.tbCounty.MaxLength = 10;
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(113, 20);
            this.tbCounty.TabIndex = 29;
            this.tbCounty.Tag = "";
            this.tbCounty.Text = "County";
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(464, 279);
            this.tbTown.MaxLength = 10;
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(113, 20);
            this.tbTown.TabIndex = 28;
            this.tbTown.Text = "Town";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(338, 279);
            this.tbStreet.MaxLength = 10;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(113, 20);
            this.tbStreet.TabIndex = 27;
            this.tbStreet.Text = "Street";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Location = new System.Drawing.Point(82, 295);
            this.dtpOrderDate.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(200, 20);
            this.dtpOrderDate.TabIndex = 31;
            this.dtpOrderDate.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // lblItemsOrdered
            // 
            this.lblItemsOrdered.AutoSize = true;
            this.lblItemsOrdered.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemsOrdered.Location = new System.Drawing.Point(639, 135);
            this.lblItemsOrdered.Name = "lblItemsOrdered";
            this.lblItemsOrdered.Size = new System.Drawing.Size(106, 16);
            this.lblItemsOrdered.TabIndex = 32;
            this.lblItemsOrdered.Text = "Items Ordered";
            // 
            // dtgrvItems
            // 
            this.dtgrvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgrvItems.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dtgrvItems.Location = new System.Drawing.Point(642, 165);
            this.dtgrvItems.Name = "dtgrvItems";
            this.dtgrvItems.Size = new System.Drawing.Size(240, 150);
            this.dtgrvItems.TabIndex = 33;
            this.dtgrvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Items";
            this.Column1.Name = "Column1";
            // 
            // lblBasket
            // 
            this.lblBasket.AutoSize = true;
            this.lblBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasket.Location = new System.Drawing.Point(722, 108);
            this.lblBasket.Name = "lblBasket";
            this.lblBasket.Size = new System.Drawing.Size(56, 16);
            this.lblBasket.TabIndex = 34;
            this.lblBasket.Text = "Basket";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.Location = new System.Drawing.Point(639, 333);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(83, 16);
            this.lblTotalPrice.TabIndex = 35;
            this.lblTotalPrice.Text = "Total price";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Location = new System.Drawing.Point(642, 352);
            this.tbTotalPrice.MaxLength = 10;
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(103, 20);
            this.tbTotalPrice.TabIndex = 36;
            this.tbTotalPrice.Text = "365.5";
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.BackColor = System.Drawing.Color.White;
            this.btnCheckOut.ForeColor = System.Drawing.Color.Black;
            this.btnCheckOut.Location = new System.Drawing.Point(642, 389);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(163, 30);
            this.btnCheckOut.TabIndex = 37;
            this.btnCheckOut.Text = "Check out";
            this.btnCheckOut.UseVisualStyleBackColor = false;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // tbOrderID
            // 
            this.tbOrderID.Location = new System.Drawing.Point(779, 352);
            this.tbOrderID.MaxLength = 5;
            this.tbOrderID.Name = "tbOrderID";
            this.tbOrderID.Size = new System.Drawing.Size(103, 20);
            this.tbOrderID.TabIndex = 39;
            this.tbOrderID.Text = "#15";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderID.Location = new System.Drawing.Point(776, 333);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(100, 16);
            this.lblOrderID.TabIndex = 38;
            this.lblOrderID.Text = "Your order ID";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(403, 202);
            this.tbAmount.MaxLength = 8;
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(101, 20);
            this.tbAmount.TabIndex = 63;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(377, 175);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(175, 16);
            this.lblAmount.TabIndex = 62;
            this.lblAmount.Text = "Please enter the amount";
            // 
            // frmNewOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 515);
            this.Controls.Add(this.tbAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.tbOrderID);
            this.Controls.Add(this.lblOrderID);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.tbTotalPrice);
            this.Controls.Add(this.lblTotalPrice);
            this.Controls.Add(this.lblBasket);
            this.Controls.Add(this.dtgrvItems);
            this.Controls.Add(this.lblItemsOrdered);
            this.Controls.Add(this.dtpOrderDate);
            this.Controls.Add(this.tbEircode);
            this.Controls.Add(this.tbCounty);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.mnsGoBack);
            this.Controls.Add(this.lblOrderDeliveryDate2);
            this.Controls.Add(this.btnNewOrderAdd);
            this.Controls.Add(this.lblOrderDeliveryDate1);
            this.Controls.Add(this.lblOrderAddress);
            this.Controls.Add(this.tbOrderType);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.pcbAddNewOrder);
            this.Name = "frmNewOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Order";
            ((System.ComponentModel.ISupportInitialize)(this.pcbAddNewOrder)).EndInit();
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgrvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbAddNewOrder;
        private System.Windows.Forms.Button btnNewOrderAdd;
        private System.Windows.Forms.Label lblOrderDeliveryDate1;
        private System.Windows.Forms.Label lblOrderAddress;
        private System.Windows.Forms.TextBox tbOrderType;
        private System.Windows.Forms.Label lblOrderType;
        private System.Windows.Forms.Label lblOrderDeliveryDate2;
        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.TextBox tbEircode;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Label lblItemsOrdered;
        private System.Windows.Forms.DataGridView dtgrvItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label lblBasket;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.TextBox tbOrderID;
        private System.Windows.Forms.Label lblOrderID;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lblAmount;
    }
}