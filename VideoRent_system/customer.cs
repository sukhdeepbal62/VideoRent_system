using System;
using System.Data;
using System.Windows.Forms;

namespace VideoRent_system
{
    public partial class customer : Form
    {
        database f = new database();
        public customer()
        {
            InitializeComponent();
        }

        private void addcustomer_button_Click(object sender, EventArgs e)
        {
            f.Add_cust(fname_text.Text, lname_text.Text, address_text.Text, phone_text.Text);
            MessageBox.Show("Customer Added");
            DataTable h1 = f.CustData();
            customer_Grid.DataSource = h1;
        }

        private void UpdateCust_Click(object sender, EventArgs e)
        {
            f.Update_cust(Convert.ToInt16(textBox1.Text), fname_text.Text, lname_text.Text, address_text.Text, Convert.ToInt32(phone_text.Text));
            MessageBox.Show("Customer Updated");
            DataTable h1 = f.CustData();
            customer_Grid.DataSource = h1;
        }

        private void DeleteCust_Click(object sender, EventArgs e)
        {
            bool result = f.Delete_cust(Convert.ToInt16(textBox1.Text));
            if (result == true)
            {
                MessageBox.Show("Customer deleted");
            }
            else
            {
                MessageBox.Show("Customer rented a movie so not deleted");
            }
            DataTable h1 = f.CustData();
            customer_Grid.DataSource = h1;
        }

        private void customer_Load(object sender, EventArgs e)
        {

            DataTable h1 = f.CustData();
            customer_Grid.DataSource = h1;
        }

        private void customer_Grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.customer_Grid.Rows[e.RowIndex];//setting the index
                textBox1.Text = row.Cells[0].Value.ToString();//setting custid

                fname_text.Text = row.Cells[1].Value.ToString();//setting fname
                lname_text.Text = row.Cells[2].Value.ToString();//setting lname
                address_text.Text = row.Cells[3].Value.ToString();//setting address
                phone_text.Text = row.Cells[4].Value.ToString();//setting phone


            }
        }
    }
}
