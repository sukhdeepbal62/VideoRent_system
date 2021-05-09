using System;
using System.Data;
using System.Windows.Forms;

namespace VideoRent_system
{
    public partial class movie : Form
    {
        database f = new database();
        public movie()
        {
            InitializeComponent();
        }

        private void addmoview_button_Click(object sender, EventArgs e)
        {
            f.Add_movi(rating_text.Text, title_text.Text, year_text.Text, copies_text.Text, plot_text.Text, genre_text.Text);
            MessageBox.Show("Movie Added");
            DataTable h = f.MoviData();
            movie_Grid.DataSource = h;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            bool result = f.Delete_movi(Convert.ToInt16(moveid_text.Text));
            if (result == true)
            {
                MessageBox.Show("Movie deleted");
            }
            else
            {
                MessageBox.Show("Movie rented by customer so not deleted");
            }
            DataTable h = f.MoviData();
            movie_Grid.DataSource = h;
        }

        private void update_button_Click(object sender, EventArgs e)
        {
            f.Update_movi(Convert.ToInt16(moveid_text.Text), rating_text.Text, title_text.Text, year_text.Text, copies_text.Text, plot_text.Text, genre_text.Text);
            MessageBox.Show("Movie updated");
            DataTable h = f.MoviData();
            movie_Grid.DataSource = h;
        }

        private void movie_Load(object sender, EventArgs e)
        {
            DataTable h = f.MoviData();
            movie_Grid.DataSource = h;
        }

        private void movie_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)//check the rowindex
                {
                    DataGridViewRow row = this.movie_Grid.Rows[e.RowIndex];//pick the row index
                    moveid_text.Text = row.Cells[0].Value.ToString();//will get the vale for moveid
                    rating_text.Text = row.Cells[1].Value.ToString();//will get the vale for rating
                    title_text.Text = row.Cells[2].Value.ToString();//will get the vale for title
                    year_text.Text = row.Cells[3].Value.ToString();//will get the vale for year
                    rentalcost_text.Text = row.Cells[4].Value.ToString();//will get the vale for rental cost
                    copies_text.Text = row.Cells[5].Value.ToString();//will get the vale for copies
                    plot_text.Text = row.Cells[6].Value.ToString();//will get the vale for plot
                    genre_text.Text = row.Cells[7].Value.ToString();//will get the vale for genre


                }
            }
            catch (Exception e1)
            {
            }
        }
    }
}
