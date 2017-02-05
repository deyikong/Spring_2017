using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingCartDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String firstName = textBox1.Text;
                //This is not a good practice
                String sql = "SELECT Id, FirstName, LastName, Email FROM dbo.Customer WHERE FirstName LIKE '%" +
                    firstName + "%'";
                String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
                SqlConnection sqlConnection = new SqlConnection(connectionString);

                sqlConnection.Open();

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);

                DataSet customers = new DataSet();

                sqlDataAdapter.Fill(customers, "Customers");
                dataGridView1.AutoGenerateColumns = true;
                dataGridView1.DataSource = customers.Tables[0];
            }
            catch (Exception ex)
            {

            }

        }
    }
}
