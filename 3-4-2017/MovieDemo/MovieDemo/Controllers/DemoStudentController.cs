using MovieDemo.Models;
using System;
using System.Collections.Generic;
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

        // GET: DemoStudent
        public ActionResult Create()
        {
            return View();
        }
    }
}