using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnSearch_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text); //Int32.Parse


        //This is not a good practice
        //Inline SQL, at risk of SQL Injection, Stored Procedure
        String sql = "SELECT Id, FirstName, LastName, Email FROM dbo.Customer WHERE Id = " + id;

        String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);

        sqlConnection.Open();

        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, sqlConnection);

        DataSet customers = new DataSet();

        sqlDataAdapter.Fill(customers, "Customers");
        DataTable dataTable = customers.Tables[0];
        if (dataTable.Rows.Count == 0)
        {
            lblInfo.Text = "Cannot find this user profile";
        }
        else
        {
            lblInfo.Text = String.Empty;//""

            txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
            txtLastName.Text = dataTable.Rows[0]["LastName"].ToString();
            lblEmail.Text = dataTable.Rows[0]["Email"].ToString();
        }

        sqlConnection.Close();
    }

    protected void btnUpdate_Click(object sender, EventArgs e)
    {
        String sql = "UPDATE dbo.Customer " +
            " SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text +
            "' WHERE Id = " + txtId.Text;

        String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
        int rows = sqlCommand.ExecuteNonQuery();

        lblInfo.Text = "User Profiler updated...";

        sqlConnection.Close();        
    }
}