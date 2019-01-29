using System;
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
    public partial class frmNewOrder : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmNewOrder()
        {
            InitializeComponent();
        }

        public frmNewOrder(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tbPhoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhoneNumber_Click(object sender, EventArgs e)
        {

        }

        private void btnNewOrderAdd_Click(object sender, EventArgs e)
        {
            validation();
        }


        public void validation()
        {
            //Validation
            if (tbOrderType.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a order type, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbOrderType.Clear();
            }

            else if (tbStreet.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid street, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbStreet.Clear();
            }
            else if (tbTown.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid town, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbTown.Clear();
            }
            else if (tbCounty.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid county, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbCounty.Clear();
            }
            else if (tbEircode.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid eircode, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbEircode.Clear();
            }
            else if(tbAmount.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid amount, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbAmount.Clear();
            }     
            else
            {
                MessageBox.Show("New order details added!", "New Orders", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearEverything();
            }
        }

        private void clearEverything()
        {
            tbOrderType.Clear();
            tbStreet.Clear();
            tbTown.Clear();
            tbCounty.Clear();
            tbEircode.Clear();
            tbAmount.Clear();
        }

        private void tbOrderType_TextChanged(object sender, EventArgs e)
        {

        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!", "Check out order", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            tbTotalPrice.Clear();
            tbOrderID.Clear();
        }
    }
}
