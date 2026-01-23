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
        StudentDB db=new StudentDB();

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

            Response.Write("Inserted");
            return View();
        }


    }
}
