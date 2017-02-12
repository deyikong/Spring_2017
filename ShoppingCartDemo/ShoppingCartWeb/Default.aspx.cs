using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ShoppingCartEntity;
using ShoppingCartDataAccess;

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
        //String sql = "SELECT Id, FirstName, LastName, Email FROM dbo.Customer WHERE Id = " + id;

        //sql = sql + "; SELECT * FROM dbo.MyOders";

        var connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
        var sqlConnection = new SqlConnection(connectionString);

        sqlConnection.Open();
        var sqlDataAdapter = new SqlDataAdapter("usp_Customer_GetOrders", sqlConnection);
        sqlDataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
        sqlDataAdapter.SelectCommand.Parameters.AddWithValue("Id", id);        

        DataSet dataSet = new DataSet();
        sqlDataAdapter.Fill(dataSet);
        //sqlDataAdapter.Fill(dataSet, "Customers");
        DataTable dataTable = dataSet.Tables[0];//customers.Tables["Customer"]
        DataTable dtMyOrders = dataSet.Tables[1];
        if (dataTable.Rows.Count == 0)
        {
            lblInfo.Text = "Cannot find this user profile";
        }
        else
        {
            lblInfo.Text = String.Empty;//""

            //txtFirstName.Text = dataTable.Rows[0]["FirstName"].ToString();
            DataRow firstDr = dataTable.Rows[0];
            //firstDr["FirstName"]
            var dc = firstDr[1];
            txtFirstName.Text = dc.ToString();

            txtLastName.Text = firstDr["LastName"].ToString();
            lblEmail.Text = firstDr["Email"].ToString();
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

    protected void btnOrmSearch_Click(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(txtId.Text);
        Customer customer = CustomerDao.Get(id);
        if (customer == null)
        {
            lblInfo.Text = "Cannot find this user profile";
        }
        else
        {
            lblInfo.Text = String.Empty;//""            
            txtFirstName.Text = customer.FirstName;
            txtLastName.Text = customer.LastName;
            lblEmail.Text = customer.Email;
        }
    }

    protected void btnUpdate2_Click(object sender, EventArgs e)
    {
        //String sql = "UPDATE dbo.Customer " +
        //   " SET FirstName = '" + txtFirstName.Text + "', LastName = '" + txtLastName.Text +
        //   "' WHERE Id = " + txtId.Text;

        //String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
        //SqlConnection sqlConnection = new SqlConnection(connectionString);
        //sqlConnection.Open();
        //SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
        //int rows = sqlCommand.ExecuteNonQuery();

        //lblInfo.Text = "User Profiler updated...";

        //sqlConnection.Close();
    }
}