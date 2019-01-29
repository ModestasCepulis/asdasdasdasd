﻿namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    partial class frmNewCustomer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewCustomer));
            this.pcbNewCustomer = new System.Windows.Forms.PictureBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblDob = new System.Windows.Forms.Label();
            this.btnNewCustomerAdd = new System.Windows.Forms.Button();
            this.mnsGoBack = new System.Windows.Forms.MenuStrip();
            this.tlmnuGoBack = new System.Windows.Forms.ToolStripMenuItem();
            this.tlmnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbEircode = new System.Windows.Forms.TextBox();
            this.tbCounty = new System.Windows.Forms.TextBox();
            this.tbTown = new System.Windows.Forms.TextBox();
            this.tbStreet = new System.Windows.Forms.TextBox();
            this.lblNewAdress = new System.Windows.Forms.Label();
            this.tbSecondName = new System.Windows.Forms.TextBox();
            this.lblSecondName = new System.Windows.Forms.Label();
            this.tbEmailAddress = new System.Windows.Forms.TextBox();
            this.lblEmailAddress = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pcbNewCustomer)).BeginInit();
            this.mnsGoBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // pcbNewCustomer
            // 
            this.pcbNewCustomer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbNewCustomer.BackgroundImage")));
            this.pcbNewCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbNewCustomer.Location = new System.Drawing.Point(123, 12);
            this.pcbNewCustomer.Name = "pcbNewCustomer";
            this.pcbNewCustomer.Size = new System.Drawing.Size(136, 112);
            this.pcbNewCustomer.TabIndex = 0;
            this.pcbNewCustomer.TabStop = false;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(92, 155);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(201, 16);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "Please enter your first name";
            this.lblFirstName.Click += new System.EventHandler(this.lblFirstAndSecondName_Click);
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(128, 183);
            this.tbFirstName.MaxLength = 15;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(131, 20);
            this.tbFirstName.TabIndex = 2;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstAndLastName_TextChanged);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(98, 448);
            this.tbPhoneNumber.MaxLength = 13;
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(200, 20);
            this.tbPhoneNumber.TabIndex = 6;
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(80, 417);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(232, 16);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "Please enter your phone number";
            // 
            // lblDob
            // 
            this.lblDob.AutoSize = true;
            this.lblDob.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDob.Location = new System.Drawing.Point(80, 355);
            this.lblDob.Name = "lblDob";
            this.lblDob.Size = new System.Drawing.Size(217, 16);
            this.lblDob.TabIndex = 7;
            this.lblDob.Text = "Please enter your date or birth";
            // 
            // btnNewCustomerAdd
            // 
            this.btnNewCustomerAdd.BackColor = System.Drawing.Color.White;
            this.btnNewCustomerAdd.ForeColor = System.Drawing.Color.Black;
            this.btnNewCustomerAdd.Location = new System.Drawing.Point(123, 550);
            this.btnNewCustomerAdd.Name = "btnNewCustomerAdd";
            this.btnNewCustomerAdd.Size = new System.Drawing.Size(163, 30);
            this.btnNewCustomerAdd.TabIndex = 9;
            this.btnNewCustomerAdd.Text = "Add";
            this.btnNewCustomerAdd.UseVisualStyleBackColor = false;
            this.btnNewCustomerAdd.Click += new System.EventHandler(this.btnNewCustomerAdd_Click);
            // 
            // mnsGoBack
            // 
            this.mnsGoBack.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tlmnuGoBack});
            this.mnsGoBack.Location = new System.Drawing.Point(0, 0);
            this.mnsGoBack.Name = "mnsGoBack";
            this.mnsGoBack.Size = new System.Drawing.Size(406, 24);
            this.mnsGoBack.TabIndex = 10;
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
            // dtpDateOfBirth
            // 
            this.dtpDateOfBirth.Location = new System.Drawing.Point(95, 383);
            this.dtpDateOfBirth.MaxDate = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            this.dtpDateOfBirth.Name = "dtpDateOfBirth";
            this.dtpDateOfBirth.Size = new System.Drawing.Size(200, 20);
            this.dtpDateOfBirth.TabIndex = 11;
            this.dtpDateOfBirth.Value = new System.DateTime(2018, 12, 6, 0, 0, 0, 0);
            // 
            // tbEircode
            // 
            this.tbEircode.Location = new System.Drawing.Point(199, 320);
            this.tbEircode.MaxLength = 10;
            this.tbEircode.Name = "tbEircode";
            this.tbEircode.Size = new System.Drawing.Size(113, 20);
            this.tbEircode.TabIndex = 30;
            this.tbEircode.Text = "Eircode";
            // 
            // tbCounty
            // 
            this.tbCounty.Location = new System.Drawing.Point(73, 320);
            this.tbCounty.MaxLength = 10;
            this.tbCounty.Name = "tbCounty";
            this.tbCounty.Size = new System.Drawing.Size(113, 20);
            this.tbCounty.TabIndex = 29;
            this.tbCounty.Tag = "";
            this.tbCounty.Text = "County";
            // 
            // tbTown
            // 
            this.tbTown.Location = new System.Drawing.Point(199, 294);
            this.tbTown.MaxLength = 10;
            this.tbTown.Name = "tbTown";
            this.tbTown.Size = new System.Drawing.Size(113, 20);
            this.tbTown.TabIndex = 28;
            this.tbTown.Text = "Town";
            // 
            // tbStreet
            // 
            this.tbStreet.Location = new System.Drawing.Point(73, 294);
            this.tbStreet.MaxLength = 10;
            this.tbStreet.Name = "tbStreet";
            this.tbStreet.Size = new System.Drawing.Size(113, 20);
            this.tbStreet.TabIndex = 27;
            this.tbStreet.Text = "Street";
            // 
            // lblNewAdress
            // 
            this.lblNewAdress.AutoSize = true;
            this.lblNewAdress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewAdress.Location = new System.Drawing.Point(95, 265);
            this.lblNewAdress.Name = "lblNewAdress";
            this.lblNewAdress.Size = new System.Drawing.Size(191, 16);
            this.lblNewAdress.TabIndex = 26;
            this.lblNewAdress.Text = "Please enter your address";
            // 
            // tbSecondName
            // 
            this.tbSecondName.Location = new System.Drawing.Point(128, 237);
            this.tbSecondName.MaxLength = 15;
            this.tbSecondName.Name = "tbSecondName";
            this.tbSecondName.Size = new System.Drawing.Size(131, 20);
            this.tbSecondName.TabIndex = 32;
            // 
            // lblSecondName
            // 
            this.lblSecondName.AutoSize = true;
            this.lblSecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondName.Location = new System.Drawing.Point(92, 209);
            this.lblSecondName.Name = "lblSecondName";
            this.lblSecondName.Size = new System.Drawing.Size(227, 16);
            this.lblSecondName.TabIndex = 31;
            this.lblSecondName.Text = "Please enter your second name";
            // 
            // tbEmailAddress
            // 
            this.tbEmailAddress.Location = new System.Drawing.Point(98, 512);
            this.tbEmailAddress.MaxLength = 13;
            this.tbEmailAddress.Name = "tbEmailAddress";
            this.tbEmailAddress.Size = new System.Drawing.Size(200, 20);
            this.tbEmailAddress.TabIndex = 34;
            // 
            // lblEmailAddress
            // 
            this.lblEmailAddress.AutoSize = true;
            this.lblEmailAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmailAddress.Location = new System.Drawing.Point(80, 481);
            this.lblEmailAddress.Name = "lblEmailAddress";
            this.lblEmailAddress.Size = new System.Drawing.Size(233, 16);
            this.lblEmailAddress.TabIndex = 33;
            this.lblEmailAddress.Text = "Please enter your email address";
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 649);
            this.Controls.Add(this.tbEmailAddress);
            this.Controls.Add(this.lblEmailAddress);
            this.Controls.Add(this.tbSecondName);
            this.Controls.Add(this.lblSecondName);
            this.Controls.Add(this.tbEircode);
            this.Controls.Add(this.tbCounty);
            this.Controls.Add(this.tbTown);
            this.Controls.Add(this.tbStreet);
            this.Controls.Add(this.lblNewAdress);
            this.Controls.Add(this.dtpDateOfBirth);
            this.Controls.Add(this.btnNewCustomerAdd);
            this.Controls.Add(this.lblDob);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.pcbNewCustomer);
            this.Controls.Add(this.mnsGoBack);
            this.MainMenuStrip = this.mnsGoBack;
            this.Name = "frmNewCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Customer";
            ((System.ComponentModel.ISupportInitialize)(this.pcbNewCustomer)).EndInit();
            this.mnsGoBack.ResumeLayout(false);
            this.mnsGoBack.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbNewCustomer;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Button btnNewCustomerAdd;
        private System.Windows.Forms.MenuStrip mnsGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuGoBack;
        private System.Windows.Forms.ToolStripMenuItem tlmnuBack;
        private System.Windows.Forms.DateTimePicker dtpDateOfBirth;
        private System.Windows.Forms.TextBox tbEircode;
        private System.Windows.Forms.TextBox tbCounty;
        private System.Windows.Forms.TextBox tbTown;
        private System.Windows.Forms.TextBox tbStreet;
        private System.Windows.Forms.Label lblNewAdress;
        private System.Windows.Forms.TextBox tbSecondName;
        private System.Windows.Forms.Label lblSecondName;
        private System.Windows.Forms.TextBox tbEmailAddress;
        private System.Windows.Forms.Label lblEmailAddress;
    }
}