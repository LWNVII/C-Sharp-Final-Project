using System;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class supplierInfoFrm : Form
    {

        // Creates a instance of a form of class type supplierInfoFrm and two temporary variables that can be accessed by the contactInfoFrm.
        public static supplierInfoFrm instance;
        public TextBox txtPhoneInp;
        public TextBox txtAddressInp;

        public supplierInfoFrm()
        {
            InitializeComponent();

            // Sets the instance's values equal to the main form.
            instance = this;

            // Sets the text box values equal to each other so one change of contactInfoFrm, values in the text box are updated on supplierInfoFrm.
            txtPhoneInp = txtPhone;
            txtAddressInp = txtEmail;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'northwindDataSet.Suppliers' table. You can move, or remove it, as needed.
            this.suppliersTableAdapter.Fill(this.northwindDataSet.Suppliers);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        // Methods for navigation buttons that cycle through the information in the Suppliers table.
        private void button4_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveLast();
        }

        // Nav button
        private void btnFirst_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveFirst();
        }

        // Nav button
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MovePrevious();
        }

        // Last navigation button.
        private void btnNext_Click(object sender, EventArgs e)
        {
            suppliersBindingSource.MoveNext();
        }
        
        // Event handler for clicking the save button.
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validates data, stops updating, and updates the table's values.
            this.Validate();
            this.suppliersBindingSource.EndEdit();
            this.suppliersTableAdapter.Update(this.northwindDataSet.Suppliers);
        }

        // Event handler for clicking update button.
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Creates instance of contactInfoFrm and displays it.
            contactInfoFrm contactInfoFrm1 = new contactInfoFrm(txtCompany.Text);
            contactInfoFrm1.ShowDialog();

        }

        // Closes the form.
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
