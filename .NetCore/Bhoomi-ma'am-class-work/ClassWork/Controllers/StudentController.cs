using Microsoft.AspNetCore.Mvc;

namespace ClassWork.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult addStudent()
        {
            return View();
        }
    }
}
