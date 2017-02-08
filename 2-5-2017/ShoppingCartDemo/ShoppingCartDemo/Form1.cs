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
                GetData();
            }
            catch (Exception ex)
            {

            }

        }

        private void GetData()
        {
            String firstName = textBox1.Text;
            //This is not a good practice
            //Inline SQL, at risk of SQL Injection, Stored Procedure
            String sql = "SELECT Id, FirstName, LastName, Email FROM dbo.Customer WHERE FirstName LIKE '%" +
                firstName + "%'";
            String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
            SqlConnection sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);

            DataSet customers = new DataSet();

            sqlDataAdapter.Fill(customers, "Customers");
            dataGridView1.AutoGenerateColumns = true;
            //Check if there is any records
            DataTable dataTable = customers.Tables[0];
            if (dataTable.Rows.Count == 0)
            {
                label2.Text = "No records";
            }
            else
            {
                label2.Text = String.Empty;//""
                dataGridView1.DataSource = dataTable;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            GetData();
        }
    }
}
