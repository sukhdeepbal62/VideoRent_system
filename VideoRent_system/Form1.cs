using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoRent_system
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Customer_Click(object sender, EventArgs e)
        {
            customer d = new customer();
            d.Show();

        }

        private void Movie_Click(object sender, EventArgs e)
        {
            movie d = new movie();
            d.Show();
        }

        private void Rental_Click(object sender, EventArgs e)
        {
            rental r = new rental();
            r.Show();
        }
    }
}
