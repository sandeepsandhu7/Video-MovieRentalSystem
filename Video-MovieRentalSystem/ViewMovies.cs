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
    public partial class ViewMovies : Form
    {
        public ViewMovies()
        {
            InitializeComponent();
        }

        private void ViewMovies_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DatabaseQueries().findallmovies();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateAndDeleteMovie f2 = new UpdateAndDeleteMovie();
            f2.txtMovieID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            f2.txtTitle.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            f2.txtRating.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            f2.txtYear.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            f2.txtCopies.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            f2.txtPlot.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();
            f2.txtGenre.Text = this.dataGridView1.CurrentRow.Cells[7].Value.ToString();
            f2.ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new DatabaseQueries().findallmovies();
        }
    }
}
