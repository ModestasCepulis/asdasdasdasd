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
    public partial class frmReplenishStock : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmReplenishStock()
        {
            InitializeComponent();
        }

        public frmReplenishStock(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(tbAmountOfItems.Text.Equals(""))
            {
                MessageBox.Show("You entered invalid amount! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbAmountOfItems.Clear();
                MessageBox.Show("The stock is ordered!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}
