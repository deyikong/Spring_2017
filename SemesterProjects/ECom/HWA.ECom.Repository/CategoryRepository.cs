using HWA.ECom.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWA.ECom.Repository
{
    class CategoryRepository
    {

        //CRUD, 
        public Boolean Insert(Category category)
        {
            ////ADO.NET
            //using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            //{
            //    con.Open();
            //    string query = "Insert into DemoStudent (FirstName, LastName, University, Gender) values('" + model.FirstName + "','" + model.LastName + "','" + model.University + "','" + model.Gender + "')";

            //    SqlCommand cmd = new SqlCommand(query, con);
            //    if (cmd.ExecuteNonQuery() == 1)
            //        return true;
            //}

            return false;
        }



    }
}
