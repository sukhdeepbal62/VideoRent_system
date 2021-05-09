using System;
using System.Data;
using System.Windows.Forms;

namespace VideoRent_system
{
    public partial class rental : Form
    {
        database f = new database();
        public rental()
        {
            InitializeComponent();
        }

        private void issue_button_Click(object sender, EventArgs e)
        {
            f.Issue_Movi(Convert.ToInt16(movieid_text.Text), Convert.ToInt16(Custid_text.Text), Convert.ToDateTime(rentdate_text.Text), 1);
            MessageBox.Show("Movie issues");

        }

        private void return_button_Click(object sender, EventArgs e)
        {
            f.Return_Movi(Convert.ToInt16(RMID_text.Text), Convert.ToInt16(movieid_text.Text), Convert.ToDateTime(rentdate_text.Text), Convert.ToDateTime(returndate_text.Text), 1);
            MessageBox.Show("Book Returned");
        }

        private void Top_buy_Click(object sender, EventArgs e)
        {
            String str = f.Top_Movie();
            MessageBox.Show(str);
        }

        private void Best_buy_Click(object sender, EventArgs e)
        {
            String str = f.Best_Buyer();
            MessageBox.Show(str);
        }

        private void allrent_radio_CheckedChanged(object sender, EventArgs e)
        {
            DataTable g = f.RentData();
            rentalGrid.DataSource = g;
        }

        private void rentedout__CheckedChanged(object sender, EventArgs e)
        {
            DataTable g = f.RentoutData();
            rentalGrid.DataSource = g;
        }

        private void rental_Load(object sender, EventArgs e)
        {
            DataTable g = f.RentData();
            rentalGrid.DataSource = g;
        }

        private void rentalGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.rentalGrid.Rows[e.RowIndex];

                RMID_text.Text = row.Cells[0].Value.ToString();

                movieid_text.Text = row.Cells[1].Value.ToString();//setting the movie text
                Custid_text.Text = row.Cells[2].Value.ToString();//setting the customerid
                rentdate_text.Text = row.Cells[3].Value.ToString();//setting the rent date
                returndate_text.Text = row.Cells[4].Value.ToString();//setting return date


            }
        }
    }
}
