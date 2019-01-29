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
    public partial class frmNewStock : Form
    {

        frmMainMenu home = new frmMainMenu();

        public frmNewStock()
        {
            InitializeComponent();
        }

        public frmNewStock(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        private void frmNewStock_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(tbAmountOfItems.Text.Equals(""))
            {
                MessageBox.Show("You entered invalid amount! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tbStockType.Text.Equals(""))
            {
                MessageBox.Show("You entered invalid stock type! Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                tbAmountOfItems.Clear();
                tbStockType.Clear();
                MessageBox.Show("The stock is added!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
