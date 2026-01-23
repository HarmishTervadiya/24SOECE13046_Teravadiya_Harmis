using MVC_Practice.DB_CODE;
using MVC_Practice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Practice.Controllers
{
    public class StudentController : Controller
    {
        StudentDB db = new StudentDB();

        // GET: Student
        public ActionResult addStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult addStudent(StudentModel s)
        {
            if (ModelState.IsValid)
            {
                db.insert(s);
            }
            else
            {
                Response.Write("Not valid");
            }

            Response.Write("Inserted");
            return View();
        }

        public ActionResult updateStudent()
        {
            return View();
        }

        [HttpPost]
        public ActionResult updateStudent(StudentModel s)
        {

            if (ModelState.IsValid)
            {
                db.update(s);
            }
            else
            {
                Response.Write("Not valid");
            }

            Response.Write("Updated");
            return View();
        }
    }
}
