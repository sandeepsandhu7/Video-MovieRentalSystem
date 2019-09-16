using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Video_MovieRentalSystem
{
    public partial class UpdateAndDeleteCustomer : Form
    {
        public UpdateAndDeleteCustomer()
        {
            InitializeComponent();
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {
            DatabaseQueries database = new DatabaseQueries();
            database.editcustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNo.Text,txtCustID.Text);
            MessageBox.Show("Customer Updated");
            Dispose();
        }

        private void btnDaleteCustomer_Click(object sender, EventArgs e)
        {
            DatabaseQueries database = new DatabaseQueries();
            database.deletecustomer(txtCustID.Text);
            MessageBox.Show("Customer Deleted");
            Dispose();
        }
    }
}
