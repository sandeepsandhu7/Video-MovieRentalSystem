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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        void ShowDialog(Form form)
        {
            form.ShowDialog();
        }
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            ShowDialog(new AddCustomer() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnViewCustomer_Click(object sender, EventArgs e)
        {
            ShowDialog(new ViewCustomer() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnIssueMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new Issue() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new AddMovie() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnViewMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new ViewMovies() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnRerurnMovie_Click(object sender, EventArgs e)
        {
            ShowDialog(new Return() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnTopCustomer_Click(object sender, EventArgs e)
        {
            ShowDialog(new Reports() { StartPosition = FormStartPosition.CenterScreen });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
