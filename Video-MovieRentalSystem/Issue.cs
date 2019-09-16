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
    public partial class Issue : Form
    {
        private string Id;
        public Issue()
        {
            InitializeComponent();
        }
        public Issue(string Id)
        {
            this.Id = Id;
            InitializeComponent();
            comboBox1.SelectedValue = Id;
        }

        private void Issue_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rentedMoviesDataSet2.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.rentedMoviesDataSet2.Customer);
            // TODO: This line of code loads data into the 'rentedMoviesDataSet1.Movies' table. You can move, or remove it, as needed.
            this.moviesTableAdapter.Fill(this.rentedMoviesDataSet1.Movies);

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (lastname.Text == "")
            {
                MessageBox.Show("Enter valid Customer ID");
            }
            else
            {
                //string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                DatabaseQueries database = new DatabaseQueries();
                database.addrentalrecord(Convert.ToInt32(comboBox1.SelectedValue), Convert.ToInt32(comboBox2.SelectedValue.ToString()), Convert.ToDateTime(dateTimePicker1.Text));

                MessageBox.Show("Movie Rented");
                //Dispose();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            firstname.Text = "";
            lastname.Text = "";
            address.Text = "";
            phoneno.Text = "";

            DataTable table = new DatabaseQueries().findcustomerbyid(comboBox2.SelectedValue.ToString());

            if (table.Rows.Count > 0)
            {
                firstname.Text = table.Rows[0]["FirstName"].ToString();
                lastname.Text = table.Rows[0]["LastName"].ToString();
                address.Text = table.Rows[0]["Address"].ToString();
                phoneno.Text = table.Rows[0]["Phone"].ToString();
            }
        }
    }
}
