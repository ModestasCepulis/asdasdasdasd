using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GD_EE_ASS_MODESTAS_CEPULIS
{
    public partial class frmNewCustomer : Form
    {
      
        frmMainMenu home = new frmMainMenu();

        public frmNewCustomer()
        {
 
            InitializeComponent();
        } 

        //the argument constructer
        public frmNewCustomer(frmMainMenu Home)
        {

            InitializeComponent();
            home = Home;
        }

        private void lblFirstAndSecondName_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void tbFirstAndLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNewCustomerAdd_Click(object sender, EventArgs e)
        {
            //validate data
            if(!validEmail(tbEmailAddress.Text))
            {
                MessageBox.Show("Email address is invalid", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbEmailAddress.Focus();
                return;
            }
            validation();

            //save data


            //display confirmation message


            //reset UI

         }

        //Creates a method that clears every input made by customer
        private void clearEverything()
        {
            tbFirstName.Clear();
            tbStreet.Clear();
            tbTown.Clear();
            tbCounty.Clear();
            tbEircode.Clear();
            tbPhoneNumber.Clear();
            tbSecondName.Clear();
            tbEmailAddress.Clear();
        }

        public void validation()
        {
            //Validation
            if (tbFirstName.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid first name, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbFirstName.Clear();
            }

            else if (tbStreet.Text.Equals(""))
            {
                MessageBox.Show("You did not enter valid street, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbStreet.Clear();
            }
            else if(tbSecondName.Equals(""))
            {
                MessageBox.Show("You did not enter a valid second name, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbSecondName.Clear();
            }

            else if (tbTown.Text.Equals(""))
            {
                MessageBox.Show("You did not enter valid town, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbTown.Clear();
            }

            else if (tbCounty.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid county, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbCounty.Clear();
            }
            else if (tbEircode.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a eircode, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbEircode.Clear();
            }
            else if (tbEmailAddress.Text.Equals(""))
            {
                MessageBox.Show("You did not enter a valid e-mail address, please try again!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tbEmailAddress.Clear();
            }
            else
            {
                MessageBox.Show("New customer details added!", "New Customers", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                clearEverything();
            }
        }      


        private void tlmnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Visible = true;
        }

        public bool validEmail(String inStr)
        {
            if (Regex.IsMatch(inStr,
                           @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + 
                           @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
