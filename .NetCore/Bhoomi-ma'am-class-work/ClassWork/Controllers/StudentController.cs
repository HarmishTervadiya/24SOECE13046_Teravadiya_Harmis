using ClassWork.BACKEND;
using ClassWork.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClassWork.Controllers
{
    public class StudentController : Controller
    {
        private StudentDB db;

        public StudentController(StudentDB db)
        {
            this.db = db;
        }

        public IActionResult Index()
        {
            var students = db.student.ToList();
            return View(students);
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
                return RedirectToAction("Index");
            }

            return View(s);
        }

        public IActionResult updateStudent(int id)
        {
            var student = db.student.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult updateStudent(StudentModel s)
        {
            if (ModelState.IsValid)
            {
                var existingStudent = db.student.Find(s.Id);
                if (existingStudent != null)
                {
                    existingStudent.Name = s.Name;
                    existingStudent.Branch = s.Branch;
                    existingStudent.EnrollmentNo = s.EnrollmentNo;
                    db.SaveChanges();
                }
                return RedirectToAction("Index");
            }

            return View(s);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            var student = db.student.Find(id);
            if (student != null)
            {
                db.student.Remove(student);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
