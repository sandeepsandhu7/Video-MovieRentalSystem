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
    public partial class ViewCustomer : Form
    {
        public ViewCustomer()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewCustomer_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DatabaseQueries().findallcustomers();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateAndDeleteCustomer f1 = new UpdateAndDeleteCustomer();
            f1.txtCustID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f1.txtFirstName.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f1.txtLastName.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f1.txtAddress.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f1.txtPhoneNo.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            f1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DatabaseQueries().findallcustomers();
        }
    }
}
