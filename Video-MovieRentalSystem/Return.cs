﻿using System;
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
    public partial class Return : Form
    {
        public Return()
        {
            InitializeComponent();
            dataGridView1.DataSource = new DatabaseQueries().getpendingrentals();
        }

        private void returnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure to return this rental?", "Return Confirmation", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                //string Date = DateTime.Now.ToString("MM/dd/yyyy") + " " + DateTime.Now.ToShortTimeString();
                DatabaseQueries database = new DatabaseQueries();
                database.updatereturnrecord(Convert.ToDateTime(DateTime.Now.ToString()), dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                MessageBox.Show("Movie Returned");

                dataGridView1.DataSource = new DatabaseQueries().getpendingrentals();
            }
        }
    }
}
