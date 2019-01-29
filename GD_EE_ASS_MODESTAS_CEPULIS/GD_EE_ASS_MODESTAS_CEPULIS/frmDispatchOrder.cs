﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    public partial class frmDispatchOrder : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmDispatchOrder()
        {
            InitializeComponent();
        }

        public frmDispatchOrder(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void btnRemoveCustomer_Click(object sender, EventArgs e)
        {
            if (tbPassword.Text.Equals(""))

            {
                MessageBox.Show("You did not enter the right password!", "Remove Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Customer status updated!", "Remove Customer Details", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                tbPassword.Clear();
            }
        }
    }
}
