using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class contactInfoFrm : Form
    {
        // Initializes a variable to hold the company name.
        private string companyName;

        public contactInfoFrm(string companyName)
        {
            InitializeComponent();
            // Stores value passed when form is made to variable company name.
            this.companyName = companyName;

        }

        private void contactInfoFrm_Load(object sender, EventArgs e)
        {
            // lblPrompt = "Please enter contact information for " + companyName;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void contactInfoFrm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);
            // Dynamically gives prompt based on what company user had selected when Update was pressed.
            lblPrompt.Text = "Please update the phone and address information for " + companyName + ".";
        }

        // Closes the form.
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // Continue button.
        private void btnContinue_Click(object sender, EventArgs e)
        {
            // Displays dialog box with prompt so user can select yes or no to proceed with entry, or to delete it.
            string message = "Does your entry look correct? \nPhone: " + txtPhone.Text + "\nAddress: " + txtAddress.Text;
            DialogResult answer = MessageBox.Show(message, "Confirm Entry", MessageBoxButtons.YesNo);
            if (answer == DialogResult.Yes)
            {
                // Updates the text boxes within supplierInfoFrm to the values entered by the user in contactInfoFrm.
                supplierInfoFrm.instance.txtPhoneInp.Text = txtPhone.Text;
                supplierInfoFrm.instance.txtAddressInp.Text = txtAddress.Text;
                this.Close();
            }
        }
    }
}
