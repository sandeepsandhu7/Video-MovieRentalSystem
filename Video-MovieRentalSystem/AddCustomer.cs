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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtAddress.Text == "" || txtPhoneNo.Text == "")
            {
                MessageBox.Show("All fields are required");
            }
            else
            {
                DatabaseQueries database = new DatabaseQueries();
                database.addnewcustomer(txtFirstName.Text, txtLastName.Text, txtAddress.Text, txtPhoneNo.Text);
                MessageBox.Show("Customer Added");
                Dispose();
            }
        }
    }
}
