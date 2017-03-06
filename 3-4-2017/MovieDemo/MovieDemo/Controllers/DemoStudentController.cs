using MovieDemo.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieDemo.Controllers
{
    public class DemoStudentController : Controller
    {
        // GET: DemoStudent
        public ActionResult Show(DemoStudent receivedUserInput)
        {
            //save to database
            //....
            return View(receivedUserInput);
        }

        public ActionResult Save(DemoStudent model)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                con.Open();
                string query = "Insert into DemoStudent (FirstName, LastName, University, Gender) values('" + model.FirstName + "','" + model.LastName + "','" + model.University + "','" + model.Gender + "')";

                SqlCommand cmd = new SqlCommand(query, con);
                if (cmd.ExecuteNonQuery() == 1)
                    return View("Show", model);
            }
            return View("Show", model);
            //return "Insert Failed!";
        }

        // GET: DemoStudent
        public ActionResult Create()
        {
            return View();
        }
    }
}