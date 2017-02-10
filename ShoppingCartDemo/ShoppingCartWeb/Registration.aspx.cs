using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnRegister_Click(object sender, EventArgs e)
    {        
        String connectionString = @"Data Source=LAPTOP-E4GLUAC2\HELLOWARE; Integrated Security=SSPI;Initial Catalog=ShoppingCart";
        SqlConnection sqlConnection = new SqlConnection(connectionString);
        sqlConnection.Open();
        SqlCommand sqlCommand = new SqlCommand("usp_Customer_Insert", sqlConnection);
        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;
        sqlCommand.Parameters.AddWithValue("FirstName", txtFirstName.Text);
        sqlCommand.Parameters.AddWithValue("LastName", txtLastName.Text);
        sqlCommand.Parameters.AddWithValue("Email", txtEmail.Text);
        sqlCommand.Parameters.AddWithValue("Phone", txtPhone.Text);
        sqlCommand.Parameters.AddWithValue("UserName", txtUserName.Text);
        sqlCommand.Parameters.AddWithValue("Password", txtPassword.Text);

        int rows = sqlCommand.ExecuteNonQuery();

        lblInfo.Text = "User registered...";

        sqlConnection.Close();
    }
}