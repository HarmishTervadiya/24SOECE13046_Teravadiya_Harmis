using ClassWork.BACKEND;
using ClassWork.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClassWork.Controllers
{
    public class StudentController : Controller
    {
        private StudentDB db;

        public StudentController(StudentDB db)
        {
            this.db = db;
        }

        public IActionResult addStudent()
        {
            return View();
        }
        [HttpPost]
        public IActionResult addStudent(StudentModel s)
        {
            if (ModelState.IsValid)
            {
                db.student.Add(s);
                db.SaveChanges();
            }

            return View();
        }
    }
}
